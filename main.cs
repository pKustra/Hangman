using System;
 
public class hangman {
    
    public hangman() {
        lives = 5;    
    }
    static public int lives;
    
    
    static public string Word(){
        string word = "haslo";
        return word;
    }
    
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
    
    static public void display(int lives){
        Console.WriteLine($"remaining lives {lives}");
        Console.WriteLine("_ _ _ _ _");
    }

    static public void Main () {
        display(5);
        return;
    }
}
