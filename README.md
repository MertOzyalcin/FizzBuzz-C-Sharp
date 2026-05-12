# C# FizzBuzz

A simple, bulletproof FizzBuzz implementation in C#. 

I built this small console application to practice core loop structures (`while` and `for`), algorithmic logic, and safe user input handling.

## How it works

The classic FizzBuzz rules apply:
- Divisible by 3 -> `Fizz`
- Divisible by 5 -> `Buzz`
- Divisible by both (15) -> `FizzBuzz`

**Key Feature:** The program includes an infinite `while` loop combined with `int.TryParse`. This means it will never crash if you type letters or symbols by mistake; it will just catch the error and politely ask for a number again until you provide a valid integer.

## Screenshot
<img width="1910" height="135" alt="image" src="https://github.com/user-attachments/assets/22898bb6-e30f-413c-bdb2-486134645a3c" />

## How to Run

Make sure you have the .NET SDK installed on your machine. Open your terminal, navigate to the project directory, and type:

```bash
dotnet run
