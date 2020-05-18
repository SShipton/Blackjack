using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack
{
  class Program
  {
    static void Main(string[] args)
    {
      var deck = new List<string>() {"Ace of Hearts", "2 of Hearts", "3 of Hearts", "4 of Hearts", "5 of Hearts", "6 of Hearts", "7 of Hearts", "8 of Hearts", "9 of Hearts", "10 of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts", "Ace of Clubs", "2 of Clubs", "3 of Clubs", "4 of Clubs", "5 of Clubs", "6 of Clubs", "7 of Clubs", "8 of Clubs", "9 of Clubs", "10 of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs", "Ace of Spades", "2 of Spades", "3 of Spades", "4 of Spades", "5 of Spades", "6 of Spades", "7 of Spades", "8 of Spades", "9 of Spades", "10 of Spades", "Jack of Spades", "Queen of Spades", "King of Spades", "Ace of Diamonds", "2 of Diamonds", "3 of Diamonds", "4 of Diamonds", "5 of Diamonds", "6 of Diamonds", "7 of Diamonds", "8 of Diamonds", "9 of Diamonds", "10 of Diamonds", "Jack of Diamonds", "Queen of Diamonds", "King of Diamonds",}; 
      var hand = new List<string>() {""};

      // ***Parse List<string> to int here

      // ***Add shuffle here

      // Deal top card to Player
      var card = deck[0];
      hand.Add(card);
      deck.Remove(card);
      // Deal next top card to Player
      var cardTwo = deck[0];
      hand.Add(cardTwo);
      deck.Remove(card);

      // Bust messages
      var playerBustMessage = "Bust. House wins";
      var houseBustMessage = "Bust. Player wins";
      
      // Display which two cards were dealt
      Console.Write($"Your dealt cards are {hand[1]} and {hand[2]} for a total of ");
      // Display value once I've written Parse code above
      //
      // Variable for user hand total
      // var sumOfPlayerHand = {$"{hand[1]} + {hand[2]}"}
      //
      // Console.WriteLine($"sumOfPlayerHand"});
      while (sumOfPlayerHand < 21)
      {
        Console.WriteLine("Hit or Stand?");
        string input = Console.ReadLine();
        if (input = "Hit")
        {
          hand.Add(card);
          deck.Remove(card);
          Console.WriteLine($"Hit. Your new hand total is {sumOfPlayerHand}");
        }
        else
        {
          Console.WriteLine($"Stand. Your hand total is {sumOfPlayerHand}");
        }
        else
        {
          if (sumOfPlayerHand > 21)
          {
            Console.WriteLine($"{playerBustMessage}");
          }
        }
        else
        {
          if (sumOfPlayerHand == 21)
          {
            Console.WriteLine("Blackjack!");
          }
        }
      }
      // Deal top card to house
      var card = deck[0];
      hand.Add(card);
      deck.Remove(card);
      // Deal next top card to house
      var cardTwo = deck[0];
      hand.Add(cardTwo);
      deck.Remove(card);
      // Will show later when house reveals cards
      // Console.WriteLine($"House's dealt cards are {hand[1]} and {hand[2]}");
      // Display value once I've written Parse code above
      //
      // Variable for house hand total
      // var sumOfHouseHand = {$"{hand[1]} + {hand[2]}"}
      //
      // Console.WriteLine($"sumOfHouseHand"});
      while (sumOfHouseHand < 17 && sumOfPlayerHand <= 21)
      {
          hand.Add(card);
          deck.Remove(card);
          Console.WriteLine($"Hit. House's new hand total is {sumOfHouseHand}");
      else
      {
        if (sumOfHouseHand > 17 && < 21)
      {
        Console.WriteLine($"Stand. House's hand total is {sumOfHouseHand}");
      }
      }
      else
      {
        if (sumOfHouseHand == 21 && sumOfPlayerHand < sumOfHouseHand)
        {
          Console.WriteLine("Blackjack! House wins");
        }
      }
      else
      {
        if (sumOfHouseHand > 21 && sumOfPlayerHand > 21)
        {
        Console.WriteLine($"{playerBustMessage}");
        }
      }
      else
      {
        if (sumOfHouseHand > 21 && sumOfPlayerHand <= 21)
        {
          Console.WriteLine($"{houseBustMessage}");
        }
      }
    }
  }
