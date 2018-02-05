namespace MadLibs.Models
{
    public class WordVariables
    {
        private string _name;
        private string _noun;
        private string _verb;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string newName)
        {
            _name = newName;
        }

        public string GetNoun()
        {
            return _noun;
        }

        public void SetNoun(string newNoun)
        {
            _noun = newNoun;
        }

        public string GetVerb()
        {
            return _verb;
        }

        public void SetVerb(string newVerb)
        {
            _verb = newVerb;
        }
    }
}
