using System;
using System.Collections.Generic;
 
public class hangman {
    
    public hangman() {
        lives = 5;
        new List<char>(){'h', 'a', 's', 'l', 'o'};
    }
    static public int lives;
    static public List<char> word;
    
    
    /*static public List<char> Word(){
        var word = new List<char>(){'h', 'a', 's', 'l', 'o'};
        return word;
    }*/
    
    static public void guessingChoice(string word){
        Console.WriteLine("Would you like to guess letter(l) or whole word(w)?");
        Console.WriteLine("l/w?");
        string choice = Console.ReadLine();
        if (choice == "l"){
            guessingLetter(word);
        }
        else if (choice == "w"){
            guessingWord(word);
        }
        else{
            guessingChoice(word);
        }
    }
    
    static public void guessingLetter(string word){
        Console.WriteLine("Insert letter: ");
        string letter = Console.ReadLine();
        if(letter.Length > 1){
            Console.WriteLine("It should be a letter");
            guessingLetter(word);
        }
        
        if(word.Contains(letter)){
            //need to display correct letter
        }
        
        else{
            lives=livesDown(lives, 1);   
        }
        
    }
    
    static public void guessingWord(string word){
        Console.WriteLine("Insert word: ");
        string gWord = Console.ReadLine();
        if(gWord == word){
            Console.WriteLine("You Win!");
            //end, ask about restart
        }
        
        if(gWord != word){
            lives=livesDown(lives, 2);
        }
    }
    
    static public int livesDown(int lives, int howMany){
        
        lives=lives-howMany;
        
    if (lives < 1) {
            Console.WriteLine("game over");
            //tutaj trzeba skonczyc i zapytać o restart
        }
        return lives;
    }
    
    static public void display(int lives, List<char> displayed){
        Console.WriteLine($"remaining lives {lives}");
        Console.WriteLine(displayed);
    }

    static public void game(){
        display(lives, word);
    }

    static public void Main () {
        Dictionary<string, List<int>> map = new Dictionary<string, List<int>>();
        map.Add("a", new List<int>(){1});
        List<int> v = map["a"];
        v.Add(3);
        map["a"] = v;
foreach(int dinosaur in map["a"])
{
    Console.WriteLine(dinosaur);
}
        game();
        return;
    }
}
