error_path = "error_log.log"
try:
    from colorama import *
    import time
    import os
    from games.gtn import *
    from games.vd import *
    import subprocess
    import sys
except ModuleNotFoundError:
    print('         :-( #000')
    print('A Important Module Is Missing.')
    with open(error_path, 'w') as file_object:
        file_object.write("Error #000,  Is A Required Module Installed?\n")
    exit()


version_number = "1110"
version = "1.0"
glintlicense = "gordaelicensed"



def startup():
    time.sleep(2)
    print('Glint', version)
    print('Type Help For A List Of Commands.')


def Glint():
    while True:
        time.sleep(0.35)
        command = input(Fore.LIGHTBLUE_EX + '>>>' + Fore.RESET)

        if command == 'about':
            print('Version:', version)
            print('Version Number:', version_number)
            continue

        elif command == 'help':
            print('about - About Glint')
            print('calc - Calculator')
            print('help - help menu')
            print('games - Games Explorer')
            print('notes - release notes')
            print('programs - List Custom Programs')
            print('ls - list files')
            print('tasklist - List Running Tasks On Your System.')
            continue

        elif command == 'calc':
            print('Answer: {}'.format(eval(input('Calcuate: '))))
            continue

        elif command == 'games':
            print('Welcome To Games Explorer!')
            print('gtn - Guess That Number')
            print('vd - Virtual Dice')
            choice = input('>')

            if choice == 'gtn':
                startgtn()

            elif choice == 'vd':
                dice()
                continue


        elif command == 'notes':
            f = open("release_notes.dll", "r")

            print(f.readline())
            continue

        elif command == 'programs':
            print('These Are The Programs Mounted.')
            print('Choose The Program Name to start it')
            print('Programs:', program_name)
            program_choice = input('>')

            if program_choice == program_name:
                try:
                    if glintsoftwarelicense == glintlicense:
                        programstartup()

                    else:
                        print(Fore.RED + "This Program Is Not Licensed By Gordae." + Fore.RESET)

                except NameError:
                    print(Fore.RED + "This Program Is Not Licensed By Gordae." + Fore.RESET)
                    continue


        elif command == 'ls':
            os.system('dir')

        elif command == 'tasklist':
            os.system("tasklist")





        else:
            print(Fore.RED + 'Invalid Command, Type help for a list of commands.' + Fore.RESET)



try:
    startup()
    try:
        from customprograms.program import *
    except ModuleNotFoundError:
        def programprint():
            time.sleep(0.50)
            print('You Have No Custom Programs Installed.')

        programprint()

    Glint()
except NameError:
    print('         :-( #001')
    print('Cannot Find Required Thing')
    with open(error_path, 'w') as file_object:
        file_object.write("Error #001,  Is A Function Missing?\n")
except SystemError:
    print('         :-( #002')
    print('A Unknown System Error Has Occurred')
    with open(error_path, 'w') as file_object:
        file_object.write("Error #002,  Unknown\n")
except MemoryError:
    print('         :-( #003')
    print('A Unknown Memory Error Has Occurred')
    with open(error_path, 'w') as file_object:
        file_object.write("Error #003,  Unknown\n")
except EnvironmentError:
    print('         :-( #004')
    print('A Unknown Error With Python Has Occurred')
    with open(error_path, 'w') as file_object:
        file_object.write("Error #004,  Unknown\n")
except OSError:
    print('         :-( #005')
    print('A File Is Not Found Or Corrupted')
    with open(error_path, 'w') as file_object:
        file_object.write("Error #005,  Is A File Missing?\n")
except OverflowError:
    print('         :-( #006')
    print('A Memory Overflow Has Occurred')
    with open(error_path, 'w') as file_object:
        file_object.write("Error #006,  Do You Have Enough RAM?\n")
except ImportError:
    print('         :-( #007')
    print('A Important Module Is Corrupted')
    with open(error_path, 'w') as file_object:
        file_object.write("Error #007,  Did You Use pip Correctly?\n")
except SyntaxError:
    print('         :-( #008')
    print('Some Code Is Corrupted Or Wrong')
    with open(error_path, 'w') as file_object:
        file_object.write("Error #008,  Did You Modify The Code?\n")
except TimeoutError:
    print('         :-( #009')
    print('The System Has Timed Out')
    with open(error_path, 'w') as file_object:
        file_object.write("Error #009,  Is Your CPU Fast Enough?\n")
except RuntimeError:
    print('         :-( #010')
    print('A Unknown Error With Python Has Occurred')
    with open(error_path, 'w') as file_object:
        file_object.write("Error #010,  Unknown\n")
except WindowsError:
    print('         :-( #011')
    print('A Problem With The OS Has Occurred')
    with open(error_path, 'w') as file_object:
        file_object.write("Error #011,  Is Defender Blocking Glint?\n")
except ZeroDivisionError:
    print('         :-( #012')
    print('System Tried To Divide By Zero')
    with open(error_path, 'w') as file_object:
        file_object.write("Error #012,  Did Glint Divide By 0?\n")