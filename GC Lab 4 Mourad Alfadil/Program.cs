
bool goagain = false;
do
{
    

    //prompting the user in input their word to be translated into pig latin
    Console.WriteLine("Please type in your word to be translated");

    //storing the user input as a string called word
    string word = Console.ReadLine();

    //turning the word lowercase so that there wont be any issues with capitalization
    string wordl = word.Trim();

    bool check = "1234567890!@#$%^&*()_+/|:;'".IndexOf(wordl) >= 0;
    if (check)
    {
        Console.WriteLine("Invalid input please try again");
        continue;
    }


    //converting the word into a character array to that we can analize all letters further on
    string[] sentence = wordl.Split(" ");

    //initializing various variables that will be used further on in the program
    string piglatin = "";
    string answer = "";
    
    foreach (string s in sentence)
    {
        answer += translate(s) + " ";
    }



    Console.WriteLine(answer);

    Console.WriteLine("Would you like to restart? y/n");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        goagain = true;
    }
    else
    {
        goagain = false;
    }





    //method to creating a piglatin word with a vowel beginning

    static string translate(string word)
    {
        string translatedword = "";
        bool vowels = "aeiouyAEIOUY".IndexOf(word[0]) >= 0;
        if (vowels)
        {
            return translatedword = word + "way";
        }
        else
        {
            return translatedword = word.Substring(1) + word.Substring(0, 1) + "ay";
        }
        
    }

    //static int checkcasing(string word)
    //{
    //    for (int i=0;i < word.Length; i++)
    //    {
    //        if (!Char.IsUpper(word[i]))
    //            return 2;
    //    }
        
    //}




    //static string vowelpiglatin(string wordl)
    //{
    //    string wordbeginv = wordl + "way";
    //    return wordbeginv;
    //}

    ////method to creating a piglatin word with a const. beginning

    //static string constpiglatin(string wordl)
    //{
    //    string wordbeginc = wordl.Substring(1) + wordl.Substring(0, 1) + "ay";
    //    return wordbeginc;
    //}

    //method for testing if the beginning character in the word is a vowel

    //static bool voweltest()
    //{
    //    if (wordl(0) == ('a') || wordl(0) == ('i') || wordl(0) == ('o') || wordl(0) == ('u') || wordl(0) == ('y'))
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}




    //creating a method for a casing test
    //static Array casingtest(casing)
    //{
    //    foreach (char characters in word)
    //    {

    //    }
    //    return casing;
    //}


} while (goagain == true);



/*
 * foreach (char c in word)
 * {
 * if (char.IsUpper(c))
 * {
 * 
 * string str = new string(character_array);
*/