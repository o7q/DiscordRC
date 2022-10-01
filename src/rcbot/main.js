const { Client, GatewayIntentBits } = require("discord.js");
const fs = require("fs");
const { execFile } = require("child_process");
const { token } = require("./.settings/.token.json");

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
const pre = "$";                         // prefix
const ver = "v1.0.0";                    // version
const headTo = "# TRANSIT CONTENT [TO]"; // header
var doShutdown = false;                  // do shutdown
// object types
const shell_obj = "shell=";
// log types
const in_log = "[INFO] ";      // info logger
const lis_log = "[LISTENER] "; // listener logger

// on ready
client.once("ready", () =>
{
    execFile("discordrc_transit_dummy.exe", err => { if (err) { console.error(err) } });
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
        message.channel.send("**[DiscordRC Help]**\nWelcome to the DiscordRC help page!\n\n**[Commands]**\n**$help** (shows this message)\n**$shell** (executes a shell script)\n**$shutdown** (shuts down DiscordRC)\n**$info** (shows info about DiscordRC)");
        console.log(in_log + "Displaying help information to the requester ($help)");

        return;
    }

    if (cmd.startsWith("shell"))
    {
        const cmd_raw = cmd.replace("shell ", "");
        message.channel.send('Sending (shell) "' + cmd_raw + '" to DiscordRC.');
        console.log(lis_log + 'Heard (shell) request of "' + cmd_raw + '" ($shell) ');
        transitOut(shell_obj + cmd_raw);

        return;
    }

    if (cmd.startsWith("shutdown"))
    {
        if (doShutdown == true)
        {
            message.channel.send("Shutting down...");
            console.log(in_log + "Recieved shutdown request ($shutdown) (state = " + doShutdown + ")\n -> [SHUTTING DOWN]");
            process.exit(0);
        }
        if (doShutdown == false)
        {
            message.channel.send("Are you sure you want to shutdown **DiscordRC**? To confirm, type **$shutdown** again.");
            console.log(in_log + "Recieved shutdown request ($shutdown) (state = " + doShutdown + ")");
            doShutdown = true;
        }

        return;
    }

    if (cmd.startsWith("info"))
    {
        message.channel.send("DiscordRC " + ver + " by o7q\nhttps://github.com/o7q/DiscordRC");
		console.log(in_log + "Displaying DiscordRC info to the requester ($info)");

        return;
    }

    message.channel.send("Unknown command! (type $help for a list of commands)");

    return;
});

// transit output
function transitOut(obj)
{
    console.log(' -> Sending "' + obj + '" to the transit operator');
    fs.writeFile("transit_to", headTo + "\n" + obj, err => { if (err) { console.error(err) } });
    execFile("discordrc_transit_operator.exe", err => { if (err) { console.error(err) } });
}

// login
client.login(token);