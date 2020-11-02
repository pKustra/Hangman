using System;
 
public class hangman {
    
    static public string Word(){
        string word = "haslo";
        return word;
    }
    
    static public void guessingChoice(){
        Console.WriteLine("Would you like to guess letter(l) or whole word(w)?");
        Console.WriteLine("l/w?");
        string choice = Console.ReadLine();
        if (choice == "l"){
            guessingLetter();
        }
        else if (choice == "w"){
            guessingWord();
        }
        else{
            guessingChoice();
        }
    }
    
    static public void guessingLetter(){
        
    }
    
    static public void guessingWord(){
        
    }
    
    static public int lives(string word, string guess){
        int lives = 5;
        
        if (word.Contains(guess)){}
        else {
            lives--;
            Console.WriteLine($"lives left {lives}");
        }
        
        if (lives == 0) Console.WriteLine("game over");
        
        return lives;
    }
    
    static public void display(int lives){
        Console.WriteLine($"remaining lives {lives}");
        Console.WriteLine("_ _ _ _ _");
    }

    static public void Main () {
        display(5);
        lives("heslo","a");
        return;
    }
}
