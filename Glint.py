try:
    from colorama import *
    import time
    import os
    from games.gtn import *
    from games.vd import *
except ModuleNotFoundError:
    print('         :-( #000')
    print('A Important Module Is Missing.')

version_number = "1000"
important_notes = "This Is Not A Final Product, Please Report Bugs In Github Issues. Some Text Are Placeholders."
version = "1.0 Prerelease 3"


def startup():
    time.sleep(2)
    print('Glint', version)
    print(important_notes)
    print('Type Help For Help.')


def Glint():
    while True:
        time.sleep(1)
        command = input(Fore.LIGHTBLUE_EX + '>>>' + Fore.RESET)

        if command == 'about':
            print('Version:', version)
            print('Version Number:', version_number)

        if command == 'help':
            print('about - About Glint')
            print('calc - Calculator')
            print('games - Games Explorer')
            print('notes - release notes')

        if command == 'calc':
            print('Answer: {}'.format(eval(input('Calcuate: '))))

        if command == 'games':
            print('Welcome To Games Explorer!')
            print('gtn - Guess That Number')
            print('vd - Virtual Dice')
            choice = input('>')

            if choice == 'gtn':
                startgtn()

            if choice == 'vd':
                dice()


        if command == 'notes':
            f = open("release_notes.dll", "r")

            print(f.readline())


        else:
            print(Fore.RED + 'Invalid Command, Type help for a list of commands.' + Fore.RESET)



try:
    startup()
    Glint()
except NameError:
    print('         :-( #001')
    print('Cannot Find Required Function')
except SystemError:
    print('         :-( #002')
    print('A Unknown System Error Has Occurred')
except MemoryError:
    print('         :-( #003')
    print('A Unknown Memory Error Has Occurred')
except EnvironmentError:
    print('         :-( #004')
    print('A Unknown Error With Python Has Occurred')
except OSError:
    print('         :-( #005')
    print('A File Is Not Found Or Corrupted')
except OverflowError:
    print('         :-( #006')
    print('A Memory Overflow Has Occurred')
except ImportError:
    print('         :-( #007')
    print('A Important Module Is Corrupted')
except SyntaxError:
    print('         :-( #008')
    print('Some Code Is Corrupted Or Wrong')
except TimeoutError:
    print('         :-( #009')
    print('The System Has Timed Out')
except RuntimeError:
    print(':-( #010')
    print('A Unknown Error With Python Has Occurred')
except WindowsError:
    print(':-( #011')
    print('A Problem With The OS Has Occurred')