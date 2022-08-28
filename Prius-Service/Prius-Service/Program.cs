using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using nUpdate;
using nUpdate.UI.WindowsForms;
using nUpdate.Updating;

namespace Prius_Service
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UpdateManager manager = new UpdateManager(new Uri("https://globalserve.hu/Prius-Service/updates.json"), "<RSAKeyValue><Modulus>6eFg8qVprU0Bsuw/0IcuYIxwIxmEhvTQvJ7Sua4K2gSy29X9HtWoYeZ4bBd1/kUgq2foBtIvB3mTuF5VHVVUXvuMISRLByFNBQey7QGPpHpUZp1Ti9zc9M3De1NzrOgqMsAUvuT1XAggaZf8003HghqUU1N6UsAoTRSzT0lY6+9h1HeJRWGd9ZcGvNXjloOZxzqVhSIXtCN+h83n+WiXZ5KBVIKbIoEeoc5IiKhTxzOYgdibBukFYHvuL2/VlO624O5ta8/D0pc3488GzIIH8V4U/eYJAxpDtkDl/Lh2kTGmafuSarhPLrlh6zsx8gh+r9TosxH2OxnHetk3D2sZXTwrLJH0eTREL4+TTdTyRlVL08PWBKCDiYJS08LtQG5bIV5tRSyRmH2X/QFaWg7V5A0qMOzgoq4kUcLyMDakyLQEwzkaPyE9y/zd1mRE1Db7DITizaFA2dZsIxaqV7WjJJuIy8MnjL1qVwqEZUI6MoQykzL7F8r1PuSfxR141gaSJB1x98KGYbMf1N/ECL1fDqo91Z57YKYOi80IlB3mbnxl4bQxZ5X/vHhY765P6S61svVUONbUTKlFF+s16eaY2tuQIioqdxOasRRt/kLRACzCc4L0TcqQgmVOUiRacZVLo9UDLGbrtdXDNNynr1cN8idxG8u1IFMhv476IPdPFBBqjebJoDpN/5m36Aux/MvmdwUrKEXtyFllWmsdikEP/cvSrQUSfxSCtNtcUrEMqI/4mxCKTLEQwU8sSe4syURy1BzvRY8hI/k8ofYnz1ln0Y7NpT2HxWu/6mm1po6IONxBDOZLeCJFdW3LtdN9MUZ1X+tJia7py1hQ10vW8V1fB3Z7K4QfhEcfmMMTVSPSPg5BfTs/dI22T60mumd/OceTK6ChtM1y4/0ZzCljUO0trYE+a2JrLzMenJa3qZwmYZW57pMznCDZmCT/ZGc/czsW7XYrF4JbI3FUQmvWe2L+3ivO11jtixmfyoTjD9ueJ6zujm+ivzEHCIlq9GtrI85xyCSJecoBFA/YtWHnUmquyfbOAoQ4SzxAmCdnnukE0hvwoaSKBoH24PMFwTErqoMasTy1DI5hylPgWs6MluxbM0Hfe9EiOM4GuCm0WY0asJjrFrrqwBAbYXp2Bp7cP+zfaAidbKS5/MyXt0kvxBlFe1ZSOoz88VQw3HJ9wkF4yJJtTPdbL7htnFpbGCyYHf0hBF03zSY+TeAH4MQFwtswiyOcZ6eoPYC2r61YkDlPjUxHE+mKl8s1skKt/StZ+r8yDXQmDu2Sy1cOBIlo/Bs/2e8almjvNu4Fo8EFsLfUX3/rPtrKt64oM/bnk/72RPsfznFAM27JoaKnqN3sUEDWxQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>",
                new CultureInfo("en"));

            var updaterUI = new UpdaterUI(manager, SynchronizationContext.Current);
            updaterUI.ShowUserInterface();

            if (manager.SearchForUpdates())
            {
                manager.DownloadPackages();
                if (manager.ValidatePackages())
                    manager.InstallPackage();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
