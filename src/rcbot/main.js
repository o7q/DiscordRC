const { Client, GatewayIntentBits } = require("discord.js");
const fs = require("fs");
const { execFile } = require("child_process");
const { token } = require("./token.json");

const client = new Client
({
    intents: 
    [
        GatewayIntentBits.Guilds,
        GatewayIntentBits.GuildMessages,
        GatewayIntentBits.MessageContent,
    ]
});

// configure global variables

// misc.
const pre = "$";                     // prefix
const ver = "v1.0.0";                // version
const head = "# IN-TRANSIT OBJECTS"; // header
// object types
const shell_obj = "shell=";
// log types
const in_log = "[INFO] ";      // info logger
const lis_log = "[LISTENER] "; // listener logger

// on ready
client.once("ready", () =>
{
    console.log("            __        __ \n",
                "  ________/ /  ___  / /_\n",
                " / __/ __/ _ \\/ _ \\/ __/\n",
                "/_/  \\__/_.__/\\___/\\__/ \n",
                "DiscordRC " + ver + " by o7q\n"
    );
    client.user.setActivity("DiscordRC");
});

// on message
client.on("messageCreate", (message) =>
{
    if (!message.content.startsWith(pre) || message.author.bot) return;
    const cmd = message.content.replace("$", "");
    if (cmd == "") return;

    if (cmd.startsWith("help"))
    {
        const cmd_raw = cmd.replace("help ", "");
        message.channel.send("**[DiscordRC Help]**\nWelcome to the DiscordRC help page!\n\n**[Commands]**\n$help (shows this message)\n$shell (executes a shell script)");
        console.log(in_log + "Showing help info to the requester");

        return;
    }

    if (cmd.startsWith("shell"))
    {
        const cmd_raw = cmd.replace("shell ", "");
        message.channel.send('Sending (shell) "' + cmd_raw + '" to DiscordRC');
        console.log(lis_log + 'Heard (shell) request of "' + cmd_raw + '"');
        transitOut(shell_obj + cmd_raw);

        return;
    }

    message.channel.send("Unknown command! (type $help for a list of commands)");
    return;
});

// transit output
function transitOut(obj)
{
    console.log(' -> Sending "' + obj + '" to the transit operator');
    fs.writeFile("transit", head + "\n" + obj, err => { if (err) { console.error(err) } });
    execFile("transit_operator.exe", err => { if (err) { console.error(err) } });
}

// login
client.login(token);