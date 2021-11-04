using System;

namespace ApplicationToLearnTest
{
    public class TextOperation
    {
        public ILengthOperation LengthOperation;
        public string Text1 { get; set; }
        public string Text2 { get; set; }

        public TextOperation(ILengthOperation lengthOperation, string text1, string text2)
        {
            LengthOperation = lengthOperation;
            Text1 = text1;
            Text2 = text2;
        }
        public string GetNameCompare()
        {
            if (LengthOperation.CompareLength(Text1, Text2))
            {
                if (Palindrom())
                {
                    return "Palindrom";
                }
                else if (Anagram())
                {
                    return "Anagram";
                }
                else
                {
                    return "Brak";
                }
            }
            else
            {
                throw new Exception();
            }
        }
        public bool Anagram()
        {
            var tmp = Text1;
            for (var i = 0; i < Text2.Length; i++)
            {
                
                if (tmp.Contains(Text2[i]) == true)
                {
                    tmp = tmp.Replace(Text2[i].ToString(), string.Empty);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public bool Palindrom()
        {
            for (var i = 0; i < Text1.Length; i++)
            {
                if (Text1[i] != Text2[Text2.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}