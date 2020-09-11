from colorama import *
import time
import os
from games.gtn import *
from games.vd import *

version_number = "1000"
important_notes = "This Is Not A Final Product, Please Report Bugs In Github Issues. Some Text Are Placeholders."
version = "1.0 Prerelease 2"


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




startup()
Glint()
