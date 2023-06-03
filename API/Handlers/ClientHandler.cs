using Newtonsoft.Json;

namespace Gex.API.Handlers;

public class ClientHandler
{
    public Stream strm { get; set; }

    public ClientHandler(ref Stream stream)
    {
        strm = stream;
    }

    public void StartHandle()
    {
        Thread thr = new Thread(new ThreadStart(async ()=> await ThreadHandle()));
        thr.Start();
    }

    private async Task ThreadHandle()
    {
        Guid lastGuid = StoredVars.messages[StoredVars.messages.Count - 1].messageId;
        while(true)
        {
            if(lastGuid != StoredVars.messages[StoredVars.messages.Count - 1].messageId)
            {
                using(StreamWriter wrt = new StreamWriter(strm))
                {
                    wrt.WriteLine(await StoredVars.protector!.Protect(JsonConvert.SerializeObject(StoredVars.messages[StoredVars.messages.Count - 1])));
                }
            } else {
                continue;
            }
        }
    }
}