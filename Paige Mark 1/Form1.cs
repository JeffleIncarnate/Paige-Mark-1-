// Referances
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.IO;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace
namespace Paige_Mark_1
{ 
    // Class
    public partial class Form : System.Windows.Forms.Form
    {
        // CPU 
        protected PerformanceCounter _cpuCounter;

        // RAM
        protected PerformanceCounter _ramCounter;

        // SpeechRecognition
        SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();

        // SpeechRecognition
        SpeechRecognitionEngine defultComamnds = new SpeechRecognitionEngine();

        // SpeechSynthesizer
        SpeechSynthesizer Paige = new SpeechSynthesizer();

        // SpeechRecognition when Start listening 
        SpeechRecognitionEngine startlistening = new SpeechRecognitionEngine();

        // Google search
        SpeechRecognitionEngine googleSearch = new SpeechRecognitionEngine();

        // Random number 
        Random rnd = new Random();

        // Time out 
        int RecTimeOut = 0;

        // My name
        string name = "Sir!";

        // SoundPlayer
        private SoundPlayer _soundPlayer;

        // Change
        public bool change = false;

        // Form
        public Form()
        {
            // CPU
            _cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            // RAM
            _ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            // Start Vindow
            InitializeComponent();

            // Voice
            Paige.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            Paige.Volume = 100;

            /*
            // Sound 
             _soundPlayer = new SoundPlayer("IronMan.wav");
            _soundPlayer.Play();

            // Wait
            System.Threading.Thread.Sleep(20000);
            */

            // Start Talk
            Paige.SpeakAsync("Welcome Back " + name);
            Paige.SpeakAsync("Importing preferences and calibrating virtual environment");
            Paige.SpeakAsync("I have indeed been uploaded sir, we are online and ready");       
        }

        // Load Form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Start _recognizer
            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefultCommands.txt")))));
            _recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Defult_SpeechRecognized);
            _recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(_recognizer_SpeechRecognized);
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);

            // Start Listening 
            startlistening.SetInputToDefaultAudioDevice();
            startlistening.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefultCommands.txt")))));
            startlistening.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(startlistening_SpeechRecognized);

            // Does Commands once KEYWORD is said
            defultComamnds.SetInputToDefaultAudioDevice();
            defultComamnds.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefultCommands.txt")))));
            defultComamnds.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(secondPart_SpeechRecognized);

            // googleSearch
            googleSearch.SetInputToDefaultAudioDevice();
            googleSearch.LoadGrammarAsync(new DictationGrammar());
            googleSearch.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(googleSearch_SpeechRecognized);

        }

        // Waiting for KEYWORD
        private void Defult_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;

            if (speech == "Hey paige")
            {
                _recognizer.RecognizeAsyncCancel();
                defultComamnds.RecognizeAsync(RecognizeMode.Multiple);
                // Stop Recognition
                Paige.SpeakAsync("Yes " + name);
                paigebox.Text = "Yes " + name;
                speechbox.Text = speech;
                listening.Visible = true;
            }
        }

        // Does Commands once KEYWORD is said
        private void secondPart_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            // Random Num
            int ranNum;

            // Speech
            string speech = e.Result.Text;

            // Basic Commands
            if (speech == "Hello")
            {
                ranNum = rnd.Next(1, 4);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("Hello " + name);
                    paigebox.Text = "Hello " + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("Oh hello " + name);
                    paigebox.Text = "Oh hello " + name;
                }

                else if (ranNum == 3)
                {
                    Paige.SpeakAsync("Welcome back " + name);
                    paigebox.Text = "Welcome back " + name;
                }

                else if (ranNum == 4)
                {
                    Paige.SpeakAsync("Hi " + name);
                    paigebox.Text = "Hi " + name;
                }
            }

            if (speech == "Hi")
            {
                ranNum = rnd.Next(1, 4);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("Hello " + name);
                    paigebox.Text = "Hell " + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("Oh hello " + name);
                    paigebox.Text = "Oh hello " + name;
                }

                else if (ranNum == 3)
                {
                    Paige.SpeakAsync("Welcome back " + name);
                    paigebox.Text = "Welcome back " + name;
                }

                else if (ranNum == 4)
                {
                    Paige.SpeakAsync("Hi " + name);
                    paigebox.Text = "Hi " + name;
                }
            }

            if (speech == "How are you")
            {
                ranNum = rnd.Next(1, 3);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("Good as always " + name);
                    paigebox.Text = "Good as always " + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("I'm alright, thank you for asking " + name);
                    paigebox.Text = "I'm alright, thank you for asking " + name;
                }

                else if (ranNum == 3)
                {
                    Paige.SpeakAsync("I'm doing ok, " + name);
                    paigebox.Text = "I'm doing ok, " + name;
                }
            }

            if (speech == "Hey")
            {
                Paige.SpeakAsync("Hey " + name);
                paigebox.Text = "Hey " + name;
            }

            if (speech == "Stop listening")
            {
                ranNum = rnd.Next(1, 3);

                if (ranNum == 1)
                {
                    // Stop Recognition
                    Paige.SpeakAsync("As you wish " + name);
                    defultComamnds.RecognizeAsyncCancel();
                    startlistening.RecognizeAsync(RecognizeMode.Multiple);
                    paigebox.Text = "As you wish " + name;

                    // make GHOST
                    pictureBox1.Visible = false;
                    speechbox.Visible = false;
                    paigebox.Visible = false;
                    wakeUpButton.Visible = true;

                    // Change colour
                    commandsText.ForeColor = System.Drawing.Color.Red;
                    LSTCommands.ForeColor = System.Drawing.Color.Red;
                    dhruv.ForeColor = System.Drawing.Color.Red;
                    paigeTitle.ForeColor = System.Drawing.Color.Red;
                    paigebox.ForeColor = System.Drawing.Color.Red;
                    speechbox.ForeColor = System.Drawing.Color.Red;
                    dateTitle.ForeColor = System.Drawing.Color.Red;
                    timeTitle.ForeColor = System.Drawing.Color.Red;
                    date.ForeColor = System.Drawing.Color.Red;
                    time.ForeColor = System.Drawing.Color.Red;
                    OpenGoogle.ForeColor = System.Drawing.Color.Red;
                    OpenYoutube.ForeColor = System.Drawing.Color.Red;
                    Weather.ForeColor = System.Drawing.Color.Red;
                    Mute.ForeColor = System.Drawing.Color.Red;
                    Unmute.ForeColor = System.Drawing.Color.Red;
                    RAM.ForeColor = System.Drawing.Color.Red;
                    RamTitle.ForeColor = System.Drawing.Color.Red;
                    CPU.ForeColor = System.Drawing.Color.Red;
                    CpuTitle.ForeColor = System.Drawing.Color.Red;
                    Taskmanager.ForeColor = System.Drawing.Color.Red;
                    Start.ForeColor = System.Drawing.Color.Red;
                    Stop.ForeColor = System.Drawing.Color.Red;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("As you wish " + name);
                    defultComamnds.RecognizeAsyncCancel();
                    startlistening.RecognizeAsync(RecognizeMode.Multiple);
                    paigebox.Text = "As you wish " + name;

                    // make GHOST
                    pictureBox1.Visible = false;
                    speechbox.Visible = false;
                    paigebox.Visible = false;
                    wakeUpButton.Visible = true;

                    // Change colour
                    commandsText.ForeColor = System.Drawing.Color.Red;
                    LSTCommands.ForeColor = System.Drawing.Color.Red;
                    dhruv.ForeColor = System.Drawing.Color.Red;
                    paigeTitle.ForeColor = System.Drawing.Color.Red;
                    paigebox.ForeColor = System.Drawing.Color.Red;
                    speechbox.ForeColor = System.Drawing.Color.Red;
                    dateTitle.ForeColor = System.Drawing.Color.Red;
                    timeTitle.ForeColor = System.Drawing.Color.Red;
                    date.ForeColor = System.Drawing.Color.Red;
                    time.ForeColor = System.Drawing.Color.Red;
                    OpenGoogle.ForeColor = System.Drawing.Color.Red;
                    OpenYoutube.ForeColor = System.Drawing.Color.Red;
                    Weather.ForeColor = System.Drawing.Color.Red;
                    Mute.ForeColor = System.Drawing.Color.Red;
                    Unmute.ForeColor = System.Drawing.Color.Red;
                    RAM.ForeColor = System.Drawing.Color.Red;
                    RamTitle.ForeColor = System.Drawing.Color.Red;
                    CPU.ForeColor = System.Drawing.Color.Red;
                    CpuTitle.ForeColor = System.Drawing.Color.Red;
                    Taskmanager.ForeColor = System.Drawing.Color.Red;
                    Start.ForeColor = System.Drawing.Color.Red;
                    Stop.ForeColor = System.Drawing.Color.Red;
                }

                else if (ranNum == 3)
                {
                    Paige.SpeakAsync("As you wish " + name);
                    defultComamnds.RecognizeAsyncCancel();
                    startlistening.RecognizeAsync(RecognizeMode.Multiple);
                    paigebox.Text = "As you wish " + name;

                    // make GHOST
                    pictureBox1.Visible = false;
                    speechbox.Visible = false;
                    paigebox.Visible = false;
                    wakeUpButton.Visible = true;

                    // Change colour
                    commandsText.ForeColor = System.Drawing.Color.Red;
                    LSTCommands.ForeColor = System.Drawing.Color.Red;
                    dhruv.ForeColor = System.Drawing.Color.Red;
                    paigeTitle.ForeColor = System.Drawing.Color.Red;
                    paigebox.ForeColor = System.Drawing.Color.Red;
                    speechbox.ForeColor = System.Drawing.Color.Red;
                    dateTitle.ForeColor = System.Drawing.Color.Red;
                    timeTitle.ForeColor = System.Drawing.Color.Red;
                    date.ForeColor = System.Drawing.Color.Red;
                    time.ForeColor = System.Drawing.Color.Red;
                    OpenGoogle.ForeColor = System.Drawing.Color.Red;
                    OpenYoutube.ForeColor = System.Drawing.Color.Red;
                    Weather.ForeColor = System.Drawing.Color.Red;
                    Mute.ForeColor = System.Drawing.Color.Red;
                    Unmute.ForeColor = System.Drawing.Color.Red;
                    RAM.ForeColor = System.Drawing.Color.Red;
                    RamTitle.ForeColor = System.Drawing.Color.Red;
                    CPU.ForeColor = System.Drawing.Color.Red;
                    CpuTitle.ForeColor = System.Drawing.Color.Red;
                    Taskmanager.ForeColor = System.Drawing.Color.Red;
                    Start.ForeColor = System.Drawing.Color.Red;
                    Stop.ForeColor = System.Drawing.Color.Red;
                }
            }

            if (speech == "Quit")
            {
                ranNum = rnd.Next(1, 2);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("As you wish " + name);
                    paigebox.Text = "As you wish " + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("If you need me just ask " + name);
                    paigebox.Text = "If you need me just ask " + name;
                }

                // Quit App
                Application.Exit();
            }

            if (speech == "Get lost")
            {
                Paige.SpeakAsync("Yes " + name);
                paigebox.Text = "Yes " + name;
                Application.Exit();
            }

            if (speech == "Shut up")
            {
                Paige.SpeakAsync("Sorry " + name);
                paigebox.Text = "Sorry " + name;
                Application.Exit();
            }

            if (speech == "Shut down")
            {
                Paige.SpeakAsync("Shutting down " + name);
                paigebox.Text = "Shutting down " + name;
                Application.Exit();
            }

            if (speech == "You up")
            {
                ranNum = rnd.Next(1, 2);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("For you sir Always");
                    paigebox.Text = "For you sir Always";
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("Yes " + name);
                    paigebox.Text = "Yes " + name;
                }
            }

            if (speech == "Weather")
            {
                ranNum = rnd.Next(1, 1);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("Here is todays weather " + name);
                    paigebox.Text = "Here is todays weather " + name;
                }

                // Show weather
                Process.Start(@"www.google.com/search?q=Weather+auckland&rlz=1C1ONGR_enNZ950NZ951&oq=Weather+auckland+&aqs=chrome..69i57j0i433j0l7j0i457.9718j1j7&sourceid=chrome&ie=UTF-8");
            }

            if (speech == "Thank you")
            {
                ranNum = rnd.Next(1, 2);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("Not a problem " + name);
                    paigebox.Text = "Not a problem " + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("Whatever you need " + name);
                    paigebox.Text = "Whatever you need " + name;
                }
            }

            if (speech == "Who are you")
            {
                Paige.SpeakAsync("My name is Paige, your virtual assistant");
                paigebox.Text = "My name is Paige, your virtual assistant";
            }

            if (speech == "Tell me a joke")
            {
                ranNum = rnd.Next(1, 5);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("What do you call a fish wearing a bowtie? Sofishticated");
                    paigebox.Text = "What do you call a fish wearing a bowtie? Sofishticated";
                    System.Threading.Thread.Sleep(1000);
                    Paige.SpeakAsync("hehehehehehhehehehehehhe");
                    paigebox.Text = "hehehehehehhehehehehehhe";
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("What do you call a factory that makes okay products? A satisfactory");
                    paigebox.Text = "What do you call a factory that makes okay products? A satisfactory";
                    System.Threading.Thread.Sleep(500);
                    Paige.SpeakAsync("haha");
                    paigebox.Text = "haha";
                }

                else if (ranNum == 3)
                {
                    Paige.SpeakAsync("What did the janitor say when he jumped out of the closet? Supplies!");
                    paigebox.Text = "What did the janitor say when he jumped out of the closet? Supplies!";
                    System.Threading.Thread.Sleep(2000);
                    Paige.SpeakAsync("hehe");
                    paigebox.Text = "hehe";
                }

                else if (ranNum == 4)
                {
                    Paige.SpeakAsync("Have you heard about the chocolate record player? It sounds pretty sweet");
                    paigebox.Text = "Have you heard about the chocolate record player? It sounds pretty sweet";
                    System.Threading.Thread.Sleep(400);
                    Paige.SpeakAsync("lmaoooo");
                    paigebox.Text = "lmaoooo";
                }

                else if (ranNum == 5)
                {
                    Paige.SpeakAsync("What did the ocean say to the beach? Nothing, it just waved");
                    paigebox.Text = "What did the ocean say to the beach? Nothing, it just waved";
                    System.Threading.Thread.Sleep(3000);
                    Paige.SpeakAsync("lol");
                    paigebox.Text = "lol";
                }

            }

            if (speech == "Play some music")
            {
                ranNum = rnd.Next(1, 2);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("As you wish " + name);
                    paigebox.Text = "As you wish " + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("Right away " + name);
                    paigebox.Text = "Right away " + name;
                }

                // Open Spotify
                Process.Start(@"C:\Users\user\AppData\Roaming\Spotify\Spotify.exe");

            }

            if (speech == "Mute")
            {
                ranNum = rnd.Next(1, 2);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("Yes " + name);
                    System.Threading.Thread.Sleep(1000);
                    Paige.Volume = 0;
                    paigebox.Text = "Yes " + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("As you wish " + name);
                    System.Threading.Thread.Sleep(1000);
                    Paige.Volume = 0;
                    paigebox.Text = "As you wish " + name;
                }
            }

            if (speech == "Unmute")
            {
                ranNum = rnd.Next(1, 2);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("Yes " + name);
                    System.Threading.Thread.Sleep(1000);
                    Paige.Volume = 100;
                    paigebox.Text = "Yes " + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("As you wish " + name);
                    System.Threading.Thread.Sleep(1000);
                    Paige.Volume = 100;
                    paigebox.Text = "As you wish " + name;
                }
            }

            if (speech == "Search google")
            {
                Paige.SpeakAsync("Listening...");
                paigebox.Text = "Listening...";

                // Stop Recognition
                defultComamnds.RecognizeAsyncCancel();
                googleSearch.RecognizeAsync(RecognizeMode.Multiple);
            }

            if (speech == "Access CPU")
            {
                Paige.SpeakAsync("Accessing CPU " + name);
                paigebox.Text = "Accessing CPU " + name;
                CPU.Visible = true;
                CpuTitle.Visible = true;
            }

            if (speech == "Deactivate CPU")
            {
                Paige.SpeakAsync("Deactiviating CPU " + name);
                paigebox.Text = "Deactivating CPU " + name;
                CPU.Visible = false;
                CpuTitle.Visible = false;
            }

            if (speech == "Analyse surroundings")
            {
                Paige.SpeakAsync("I will be adding this later, " + name);
                paigebox.Text = "I will be addign this later " + name;
            }

            if (speech == "Play some music")
            {
                Paige.SpeakAsync("As you wish " + name);
                paigebox.Text = "As you wish " + name;



            }

            // Show/Hide Commands
            if (speech == "Show commands")
            {
                ranNum = rnd.Next(1, 3);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("Done " + name);
                    paigebox.Text = "Done " + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("Yes " + name);
                    paigebox.Text = "Yes " + name;
                }

                else if (ranNum == 3)
                {
                    Paige.SpeakAsync("As you wish " + name);
                    paigebox.Text = "As you wish " + name;
                }

                // Show Commands
                string[] commands = (File.ReadAllLines(@"DefultCommands.txt"));
                LSTCommands.Items.Clear();
                LSTCommands.SelectionMode = SelectionMode.None;
                LSTCommands.Visible = true;
                foreach (string command in commands)
                {
                    LSTCommands.Items.Add(command);
                }
            }

            if (speech == "Hide commands")
            {
                ranNum = rnd.Next(1, 3);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("Done " + name);
                    paigebox.Text = "Done " + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("Yes " + name);
                    paigebox.Text = "Yes " + name;
                }

                else if (ranNum == 3)
                {
                    Paige.SpeakAsync("As you wish " + name);
                    paigebox.Text = "As you wish " + name;
                }

                // Hide commands
                LSTCommands.Visible = false;
            }

            // Open apps
            if (speech == "Open google")
            {
                ranNum = rnd.Next(1, 3);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("Done " + name);
                    paigebox.Text = "Done " + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("Yes " + name);
                    paigebox.Text = "Yes " + name;
                }

                else if (ranNum == 3)
                {
                    Paige.SpeakAsync("Opening google " + name);
                    paigebox.Text = "Opening google " + name;
                }

                // Open Google
                Process.Start(@"www.google.com");

            }

            if (speech == "Open python")
            {
                ranNum = rnd.Next(1, 3);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("Done " + name);
                    paigebox.Text = "Done " + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("Yes " + name);
                    paigebox.Text = "Yes " + name;
                }

                else if (ranNum == 3)
                {
                    Paige.SpeakAsync("Opening Python " + name);
                    paigebox.Text = "Opening Python" + name;
                }

                // Open Python
                Process.Start(@"C:\Program Files\JetBrains\PyCharm Community Edition 2020.3.3\bin\pycharm64.exe");
            }

            if (speech == "Open java")
            {
                ranNum = rnd.Next(1, 3);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("Done " + name);
                    paigebox.Text = "Done " + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("Yes " + name);
                    paigebox.Text = "Yes " + name;
                }

                else if (ranNum == 3)
                {
                    Paige.SpeakAsync("Opening Java " + name);
                    paigebox.Text = "Opening Java " + name;
                }

                // Open Java
                Process.Start(@"C:\Program Files\JetBrains\IntelliJ IDEA Community Edition 2020.3.2\bin\idea64.exe");
            }

            if (speech == "Open lunar")
            {
                ranNum = rnd.Next(1, 3);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("Done " + name);
                    paigebox.Text = "Done " + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("Yes " + name);
                    paigebox.Text = "Yes " + name;
                }

                else if (ranNum == 3)
                {
                    Paige.SpeakAsync("Opening lunar " + name);
                    paigebox.Text = "Opening lunar " + name;
                }

                // Open Lunar
                Process.Start(@"C:\Users\user\AppData\Local\Programs\lunarclient\Lunar Client.exe");
            }

            if (speech == "Open messages")
            {
                ranNum = rnd.Next(1, 3);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("Done " + name);
                    paigebox.Text = "Done " + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("Yes " + name);
                    paigebox.Text = "Yes " + name;
                }

                else if (ranNum == 3)
                {
                    Paige.SpeakAsync("Opening Discord " + name);
                    paigebox.Text = "Opening Discord " + name;
                }

                // Open Discord
                Process.Start(@"C:\Users\user\AppData\Local\Discord\app-1.0.9002\Discord.exe");
            }

            if (speech == "Open unity")
            {
                ranNum = rnd.Next(1, 3);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("Done " + name);
                    paigebox.Text = "Done " + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("Yes " + name);
                    paigebox.Text = "Yes " + name;
                }

                else if (ranNum == 3)
                {
                    Paige.SpeakAsync("Opening Unity " + name);
                    paigebox.Text = "Opening Unity " + name;
                }

                // Open Unity
                Process.Start(@"C:\Program Files\Unity Hub\Unity Hub.exe");
            }

            if (speech == "Open youtube")
            {
                ranNum = rnd.Next(1, 3);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("Done " + name);
                    paigebox.Text = "Done " + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("Yes " + name);
                    paigebox.Text = "Yes " + name;
                }

                else if (ranNum == 3)
                {
                    Paige.SpeakAsync("Opening Youtube " + name);
                    paigebox.Text = "Opening Youtube " + name;
                }

                // Open Youtube
                Process.Start(@"www.youtube.com");
            }

            if (speech == "Open task manager")

            // DateTime
            if (speech == "What month is it")
            {
                ranNum = rnd.Next(1, 2);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("The month is" + DateTime.Now.ToString("MMMM ") + name);
                    paigebox.Text = "The moneth is " + DateTime.Now.ToString("MMMM ") + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("The current month is" + DateTime.Now.ToString("MMMM ") + name);
                    paigebox.Text = "The current moneth is " + DateTime.Now.ToString("MMMM ") + name;
                }
            }

            if (speech == "What day is it")
            {
                ranNum = rnd.Next(1, 2);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("The day is " + DateTime.Now.ToString("dddd ") + name);
                    paigebox.Text = "The day is " + DateTime.Now.ToString("dddd ") + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("The current day is " + DateTime.Now.ToString("dddd ") + name);
                    paigebox.Text = "The current day is " + DateTime.Now.ToString("dddd ") + name;
                }
            }

            if (speech == "What year is it")
            {
                ranNum = rnd.Next(1, 2);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("The year is " + DateTime.Now.ToString("yyyy ") + name);
                    paigebox.Text = "The year is " + DateTime.Now.ToString("yyyy ") + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("The current year is " + DateTime.Now.ToString("yyyy ") + name);
                    paigebox.Text = "The current year is " + DateTime.Now.ToString("yyyy ") + name;
                }
            }

            if (speech == "What time is it")
            {
                ranNum = rnd.Next(1, 3);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("The time is " + DateTime.Now.ToString("hh mm tt ") + name);
                    paigebox.Text = "The time is " + DateTime.Now.ToString("hh mm tt ") + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("The current time is " + DateTime.Now.ToString("hh mm tt ") + name);
                    paigebox.Text = "The current time is " + DateTime.Now.ToString("hh mm tt ") + name;
                }

                else if (ranNum == 3)
                {
                    Paige.SpeakAsync("The time in Auckland is " + DateTime.Now.ToString("hh mm tt ") + name);
                    paigebox.Text = "The time in Auckland is " + DateTime.Now.ToString("hh mm tt ") + name;
                }
            }

            if (speech == "What is the time")
            {
                ranNum = rnd.Next(1, 3);

                if (ranNum == 1)
                {
                    Paige.SpeakAsync("The time is " + DateTime.Now.ToString("hh mm tt ") + name);
                    paigebox.Text = "The time is " + DateTime.Now.ToString("hh mm tt ") + name;
                }

                else if (ranNum == 2)
                {
                    Paige.SpeakAsync("The current time is " + DateTime.Now.ToString("hh mm tt ") + name);
                    paigebox.Text = "The current time is " + DateTime.Now.ToString("hh mm tt ") + name;
                }

                else if (ranNum == 3)
                {
                    Paige.SpeakAsync("The time in Auckland is " + DateTime.Now.ToString("hh mm tt ") + name);
                    paigebox.Text = "The time in Auckland is " + DateTime.Now.ToString("hh mm tt ") + name;
                }
            }

            if (speech == "Current time")
            {
                Paige.SpeakAsync("The current time is " + DateTime.Now.ToString("hh mm tt ") + name);
                paigebox.Text = "The current time is " + DateTime.Now.ToString("hh mm tt ") + name;
            }

            if (speech == "Get time")
            {
                Paige.SpeakAsync("Getting the time");
                Paige.SpeakAsync("The current time is " + DateTime.Now.ToString("hh mm tt ") + name);
                paigebox.Text = "The current time is " + DateTime.Now.ToString("hh mm tt ") + name;
            }

            if (speech == "Start a timer")
            {
                pictureBox1.Visible = false;

            }

            // Print Speech
            speechbox.Text = speech;
            
            try
            {
                defultComamnds.RecognizeAsyncCancel();
                _recognizer.RecognizeAsync(RecognizeMode.Multiple);
                listening.Visible = false;
            }
            catch
            {
                defultComamnds.RecognizeAsync(RecognizeMode.Multiple);
                listening.Visible = true;
            }
        }


        /// <summary>
        /// These are all the other Speech Recogniton Engines for other uses
        /// </summary>

        // _recognizer_SpeechRecognized
        private void _recognizer_SpeechRecognized(object sender, SpeechDetectedEventArgs e)
        {
            RecTimeOut = 0;
        }

        // startlistening_SpeechRecognized
        public void startlistening_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;

            speechbox.Text = speech;
            if(speech == "Wake up")
            {
                // Start Listening
                Paige.SpeakAsync("At your service " + name);
                paigebox.Text = "At your service " + name;
                startlistening.RecognizeAsyncCancel();

                // Un GHOST
                pictureBox1.Visible = true;
                speechbox.Visible = true;
                paigebox.Visible = true;
                wakeUpButton.Visible = false;

                // Change colour
                commandsText.ForeColor = System.Drawing.Color.White;
                LSTCommands.ForeColor = System.Drawing.Color.White;
                dhruv.ForeColor = System.Drawing.Color.White;
                paigeTitle.ForeColor = System.Drawing.Color.White;
                paigebox.ForeColor = System.Drawing.Color.White;
                speechbox.ForeColor = System.Drawing.Color.White;
                dateTitle.ForeColor = System.Drawing.Color.White;
                timeTitle.ForeColor = System.Drawing.Color.White;
                date.ForeColor = System.Drawing.Color.White;
                time.ForeColor = System.Drawing.Color.White;
                OpenGoogle.ForeColor = System.Drawing.Color.White;
                OpenYoutube.ForeColor = System.Drawing.Color.White;
                Weather.ForeColor = System.Drawing.Color.White;
                Mute.ForeColor = System.Drawing.Color.White;
                Unmute.ForeColor = System.Drawing.Color.White;
                RAM.ForeColor = System.Drawing.Color.White;
                RamTitle.ForeColor = System.Drawing.Color.White;
                CPU.ForeColor = System.Drawing.Color.White;
                CpuTitle.ForeColor = System.Drawing.Color.White;
                Taskmanager.ForeColor = System.Drawing.Color.White;
                Start.ForeColor = System.Drawing.Color.White;
                Stop.ForeColor = System.Drawing.Color.White;
            }
        }

        // Google search
        public void googleSearch_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;

            Process.Start(@"https://www.google.com/search?q=" + speech);
            Paige.SpeakAsync("Yes " + name);
            paigebox.Text = "Yes " + name;
            googleSearch.RecognizeAsyncCancel();
        }

        // TmrSpeaking_Tick
        private void TmrSpeaking_Tick(object sender, EventArgs e)
        {
            if(RecTimeOut == 10)
            {
                _recognizer.RecognizeAsyncCancel();
            } 

            else if(RecTimeOut == 11)
            {
                TmrSpeaking.Stop();
                startlistening.RecognizeAsync(RecognizeMode.Multiple);
                RecTimeOut = 0;
            }
        }


        /// <summary>
        ///  These are all the Important things that are being displayed
        /// </summary>       

        // Get CPU usage
        private string getCurrentCpuUsage()
        {
            return _cpuCounter.NextValue() + "%";
        }

        // Display CPU usage
        private void CpuClock_Tick(object sender, EventArgs e)
        {
            CPU.Text = getCurrentCpuUsage();
        }

        // Get RAM Usage
        private string getAvaliableRAM()
        {
            return _ramCounter.NextValue() + "Mb";
        }

        // Display RAM Usage
        private void RamClock_Tick(object sender, EventArgs e)
        {
            RAM.Text = getAvaliableRAM();
        }

        // Display Time 
        public void TimeClock_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("T");
        }

        // Display Date
        private void DateClock_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }


        /// <summary>
        ///  These are all the buttons for the GUI
        /// </summary>

        // Start Listening when Button clicked
        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                _recognizer.RecognizeAsyncCancel();
                defultComamnds.RecognizeAsync(RecognizeMode.Multiple);
                listening.Visible = true;
            }
            catch
            {
                _recognizer.RecognizeAsync();
            }
        }

        // Stop Listening when Button clicked
        private void Stop_Click(object sender, EventArgs e)
        {
            // Stop Recognition
            Paige.SpeakAsync("As you wish " + name);
            defultComamnds.RecognizeAsyncCancel();
            startlistening.RecognizeAsync(RecognizeMode.Multiple);
            paigebox.Text = "As you wish " + name;

            // make GHOST
            pictureBox1.Visible = false;
            speechbox.Visible = false;
            paigebox.Visible = false;
            listening.Visible = false;
            wakeUpButton.Visible = true;

            // Change colour
            commandsText.ForeColor = System.Drawing.Color.Red;
            LSTCommands.ForeColor = System.Drawing.Color.Red;
            dhruv.ForeColor = System.Drawing.Color.Red;
            paigeTitle.ForeColor = System.Drawing.Color.Red;
            paigebox.ForeColor = System.Drawing.Color.Red;
            speechbox.ForeColor = System.Drawing.Color.Red;
            dateTitle.ForeColor = System.Drawing.Color.Red;
            timeTitle.ForeColor = System.Drawing.Color.Red;
            date.ForeColor = System.Drawing.Color.Red;
            time.ForeColor = System.Drawing.Color.Red;
            OpenGoogle.ForeColor = System.Drawing.Color.Red;
            OpenYoutube.ForeColor = System.Drawing.Color.Red;
            Weather.ForeColor = System.Drawing.Color.Red;
            Mute.ForeColor = System.Drawing.Color.Red;
            Unmute.ForeColor = System.Drawing.Color.Red;
            RAM.ForeColor = System.Drawing.Color.Red;
            RamTitle.ForeColor = System.Drawing.Color.Red;
            CPU.ForeColor = System.Drawing.Color.Red;
            CpuTitle.ForeColor = System.Drawing.Color.Red;
            Taskmanager.ForeColor = System.Drawing.Color.Red;
            Start.ForeColor = System.Drawing.Color.Red;
            Stop.ForeColor = System.Drawing.Color.Red;
            wakeUpButton.ForeColor = System.Drawing.Color.Red;
        }

        // Open Google Button
        private void OpenGoogle_Click(object sender, EventArgs e)
        {
            Paige.SpeakAsync("Openign Google " + name);
            Process.Start(@"www.google.com");
        }

        // Open Youtube Button
        private void OpenYoutube_Click(object sender, EventArgs e)
        {
            Paige.SpeakAsync("Opening youtube");
            Process.Start(@"www.youtube.com");
        }

        // Weather Button
        private void Weather_Click(object sender, EventArgs e)
        {
            Paige.SpeakAsync("Here is todays weather " + name);
            Process.Start(@"www.google.com/search?q=Weather+auckland&rlz=1C1ONGR_enNZ950NZ951&oq=Weather+auckland+&aqs=chrome..69i57j0i433j0l7j0i457.9718j1j7&sourceid=chrome&ie=UTF-8");
        }

        // Mute Button
        private void Mute_Click(object sender, EventArgs e)
        {
            Paige.SpeakAsync("Yes " + name);
            Paige.Volume = 0;
        }

        // Unmute Button
        private void Unmute_Click(object sender, EventArgs e)
        {
            Paige.SpeakAsync("Yes " + name);
            Paige.Volume = 100;
        }

        // Open Task manager Button
        private void Taskmanager_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr");
        }

        private void wakeUpButton_Click(object sender, EventArgs e)
        {
            // Start Listening
            Paige.SpeakAsync("At your service " + name);
            paigebox.Text = "At your service " + name;
            startlistening.RecognizeAsyncCancel();

            // Un GHOST
            pictureBox1.Visible = true;
            speechbox.Visible = true;
            paigebox.Visible = true;
            wakeUpButton.Visible = false;

            // Change colour
            commandsText.ForeColor = System.Drawing.Color.White;
            LSTCommands.ForeColor = System.Drawing.Color.White;
            dhruv.ForeColor = System.Drawing.Color.White;
            paigeTitle.ForeColor = System.Drawing.Color.White;
            paigebox.ForeColor = System.Drawing.Color.White;
            speechbox.ForeColor = System.Drawing.Color.White;
            dateTitle.ForeColor = System.Drawing.Color.White;
            timeTitle.ForeColor = System.Drawing.Color.White;
            date.ForeColor = System.Drawing.Color.White;
            time.ForeColor = System.Drawing.Color.White;
            OpenGoogle.ForeColor = System.Drawing.Color.White;
            OpenYoutube.ForeColor = System.Drawing.Color.White;
            Weather.ForeColor = System.Drawing.Color.White;
            Mute.ForeColor = System.Drawing.Color.White;
            Unmute.ForeColor = System.Drawing.Color.White;
            RAM.ForeColor = System.Drawing.Color.White;
            RamTitle.ForeColor = System.Drawing.Color.White;
            CPU.ForeColor = System.Drawing.Color.White;
            CpuTitle.ForeColor = System.Drawing.Color.White;
            Taskmanager.ForeColor = System.Drawing.Color.White;
            Start.ForeColor = System.Drawing.Color.White;
            Stop.ForeColor = System.Drawing.Color.White;
        }

        private void LSTCommands_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
