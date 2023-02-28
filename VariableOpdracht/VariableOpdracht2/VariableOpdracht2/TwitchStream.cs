using System;

namespace VariableOpdracht2
{
    internal class TwitchStream
    {
        //maak hier class variables aan:
        // type=string, naam: name,
        // type=string, naam: lastStreamName
        // type=Game, naam: streamGame
        // type=int, naam: followers
        // type=bool, naam: automod

        string name = "averageStreamer11";
        string lastStreamName = "BREAKING INTO SOMEONES HOUSE";
        Game streamGame = new Game("Just Chatting"); // denk dat just chatting wel past bij inbraak
        int followers = 100000;
        bool automod = true;
        
    }
}