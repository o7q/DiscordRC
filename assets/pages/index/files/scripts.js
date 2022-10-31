function bodyInit()
{
    dlConfig();
}

function dlConfig()
{
    var ver = "v1.0.0";

    document.getElementById("dlID").href = "https://github.com/o7q/DiscordRC/releases/download/" + ver + "/DiscordRC." + ver + ".7z";
    document.getElementById("dlID").innerHTML = "Download " + ver;
}