using System;
public class Library
{
    private List<Scripture> _scriptList = new List<Scripture>();
    private int _listCount;
    private int _index = 0;

    public Library()
    {
        //build a list of scriptures to use for game
        Scripture s = new Scripture("John", "3", "16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        _scriptList.Add(s);

        s = new Scripture("John", "3", "5", "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.");
        _scriptList.Add(s);

        s = new Scripture("John", "3", "12", "If I have told you earthly things, and ye believe not, how shall ye believe, if I tell you of heavenly things?");
        _scriptList.Add(s);

        s = new Scripture("John", "3", "17", "For God sent not his Son into the world to condemn the world; but that the world through him might be saved.");
        _scriptList.Add(s);

        s = new Scripture("Proverbs", "1", "7", "The fear of the Lord is the beginning of knowledge: but fools despise wisdom and instruction.");
        _scriptList.Add(s);

        s = new Scripture("Proverbs", "1", "29-33", "29 For that they hated knowledge, and did not choose the fear of the Lord: 30 They would none of my counsel: they despised all my reproof. 31 Therefore shall they eat of the fruit of their own way, and be filled with their own devices. 32 For the turning away of the simple shall slay them, and the prosperity of fools shall destroy them. 33 But whoso hearkeneth unto me shall dwell safely, and shall be quiet from fear of evil.");
        _scriptList.Add(s);

        s = new Scripture("Proverbs", "3", "13", "Happy is the man that findeth wisdom, and the man that getteth understanding.");
        _scriptList.Add(s);

        _listCount = _scriptList.Count();
    }

    public Scripture GetScripture()
    {
        //iterate through the list of scriptures again and again. Returning the next scripture in the list each time.
        if (_index >= _listCount)
        {
            //reset to first scripture
            _index = 0;
        }

        Scripture s = _scriptList[_index];
        _index++;
        return s;
    }
}