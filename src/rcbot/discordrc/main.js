const { Client, GatewayIntentBits, InteractionCollector } = require("discord.js");
const fs = require("fs");
const { execFile } = require("child_process");
const { token } = require("./_settings/_token.json");

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
    execFile("rcbot_transit_dummy.exe", err => { if (err) { console.error(err) } });

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
    let userData = []; userData = fs.readFileSync("_settings\\_sudoUsers.setting").toString().split("\n");
    for(i in userData)
    {
        let userIDData = []; userIDData = userData[i].split("|");
        if (message.author.id == userIDData[0])
        {
            if (!message.content.startsWith(pre) || message.author.bot) return;
            const cmd = message.content.replace("$", "");
            if (cmd == "") return;

            if (cmd.startsWith("help"))
            {
                const cmd_raw = cmd.replace("help ", "");
                message.channel.send("**[DiscordRC Help]**\nWelcome to the DiscordRC help page!\n\n**[Commands]**\n**$help** (shows this message)\n**$shell** (executes a shell script)\n**$rc_shutdown** (shuts down DiscordRC)\n**$info** (shows info about DiscordRC)");
                console.log(in_log + "Displaying help information to the requester ($help)");

                return;
            }

            if (cmd.startsWith("info"))
            {
                message.channel.send("DiscordRC " + ver + " by o7q\nhttps://github.com/o7q/DiscordRC");
                console.log(in_log + "Displaying DiscordRC information to the requester ($info)");
        
                return;
            }

            if (cmd.startsWith("shell"))
            {
                const cmd_raw = cmd.replace("shell ", "");
                message.channel.send('Sending (shell) "**' + cmd_raw + '**" to DiscordRC.');
                console.log(lis_log + 'Heard (shell) request of "' + cmd_raw + '" ($shell) ');
                transitOut(shell_obj + cmd_raw);

                return;
            }

            if (cmd.startsWith("rc_shutdown"))
            {
                if (doShutdown == true)
                {
                    message.channel.send("Shutting down...");
                    console.log(in_log + "Recieved an rc_shutdown request ($rc_shutdown) (state = " + doShutdown + ")\n -> SHUTTING DOWN");
                    process.exit(0);
                }
                if (doShutdown == false)
                {
                    message.channel.send("Are you sure you want to shutdown **DiscordRC**? To confirm, type **$rc_shutdown** again.");
                    console.log(in_log + "Recieved an rc_shutdown request ($rc_shutdown) (state = " + doShutdown + ")");
                    doShutdown = true;
                }

                return;
            }
        
            message.channel.send("Unknown command! (**$" + cmd + "**) (type $help for a list of commands)");   
            console.log(in_log + "User tried an unknown command ($" + cmd + ")");   
        
            return;
        }
    }
});

// transit output
function transitOut(obj)
{
    console.log(' -> Sending "' + obj + '" to the transit operator');
    fs.writeFile("transit_to", headTo + "\n" + obj, err => { if (err) { console.error(err) } });
    execFile("rcbot_transit_operator.exe", err => { if (err) { console.error(err) } });
}

// login
client.login(token);