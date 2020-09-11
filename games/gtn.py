import random

def startgtn():
    """
    The start up for "Guess that Number!"
    :return:
    """
    print("Welcome to Guess That Number!")
    input("(Enter to continue)")
    print("Try to guess the number that the computer is thinking of!")
    difficulty_4()

def difficulty_1():
    """
    A function for difficulty one. Simply made to tidy up the code a bit.
    :return:
    """
    final_value = random.randint(1, 10)
    print("I'm thinking of a number between one and 10.")
    guess = int(input("What do you think it is? "))
    if guess == final_value:
        print("You got it! The answer was", final_value, "!")
        input("Press enter to Get To Glint")
    else:
        print("Sorry. The correct answer was", final_value, ".")
        input("Press enter to play again")


def difficulty_2():
    """
    A function for difficulty one. Simply made to tidy up the code a bit.
    :return:
    """
    final_value = random.randint(1, 20)
    print("I'm thinking of a number between one and 20.")
    guess = int(input("What do you think it is? "))
    if guess == final_value:
        print("You got it! The answer was", final_value, "!")
        input("Press enter to play again")
    else:
        print("Sorry. The correct answer was", final_value, ".")
        input("Press enter to play again")


def difficulty_3():
    """
    A function for difficulty one. Simply made to tidy up the code a bit.
    :return:
    """

    final_value = random.randint(1, 100)
    print("I'm thinking of a number between one and 50.")
    guess = int(input("What do you think it is? "))
    if guess == final_value:
        print("You got it! The answer was", final_value, "!")
        input("Press enter to play again")
    else:
        print("Sorry. The correct answer was", final_value, ".")
        input("Press enter to play again")


def difficulty_4():
    """
    A function for difficulty one. Simply made to tidy up the code a bit.
    :return:
    """

    final_value = random.randint(1, 1000)
    print("I'm thinking of a number between one and 1000.")
    guess = int(input("What do you think it is? "))
    if guess == final_value:
        print("You got it! The answer was", final_value, "!")
        input("Press enter to play again")
    else:
        print("Sorry. The correct answer was", final_value, ".")
        input("Press enter to play again")


def main():
    for i in range(1000):
        try: # Turn input into an integer, catch error if user input a string and not a number.
            difficulty = int(input("Choose the difficulty: 1: pick a number between 1 and 10. 2: 1-20. 3: 1-50. 4: 1-100."))
        except TypeError:
            print("Sorry. Invalid input. Please type in a number between 1 and 4.")
            input("(Enter to continue)")

        if difficulty <= 4:
            exec("difficulty_{0}()".format(difficulty)) # Execute the function, and not have a huge amount of if statements.

        else:
            print("Sorry. Invalid input. Please type in a number between 1 and 4.")
            input("(Enter to continue)")

if __name__ == '__main__':
    startgtn()
    main()
