using System;


Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    string[] responses =
    {"As I see it, yes.", "Ask again later.", "Better not tell you now.", "Cannot predict now.", "Concentrate and ask again.", "Don’t count on it.", "It is certain.", "It is decidedly so.", "Most likely.", "My reply is no.", "My sources say no.", "Outlook not so good", "Outlook good.", "Reply hazy, try again.", "Signs point to yes", "Very doubtful.", "Without a doubt.", "Yes.", "Yes – definitely.", "You may rely on it."
    };

    AskQuestion();

    void AskQuestion()
    {
        Console.Write("Ask the moose a question: ");
        string question = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(question))
        {
            Console.WriteLine("Bye!");
        }
        else
        {
            // foreach (string response in responses)
            Random r = new Random();
            int genRand = r.Next(0, responses.Length - 1);
            MagicBall(responses[genRand]);
            // {
            //     Console.WriteLine("Random response = " + (responses[genRand]));
            // }
            AskQuestion();
        }
    }
}



void MagicBall(string response)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {response}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}
