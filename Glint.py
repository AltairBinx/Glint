from colorama import *
import time
from os import *
import os

version_number = "1000"
important_notes = "This Is Not A Final Product, Please Report Bugs In Github Issues. Some Text Are Placeholders."


def startup():
    time.sleep(2)
    print('Glint 1.0 Prerelease 1')
    print(important_notes)
    print('Type Help For Help.')


def Glint():
    while True:
        time.sleep(1)
        command = input(Fore.LIGHTBLUE_EX + '>>>' + Fore.RESET)

        if command == 'about':
            print('Version Number:', version_number)

        if command == 'help':
            print('about - About Glint')


startup()
Glint()
