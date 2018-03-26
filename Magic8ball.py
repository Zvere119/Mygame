import random

def getAnswer(answerNumber):
    if answerNumber == 1:
        return ' It is certain'
    elif answerNumber == 2:
        return ' It is decidedly so'
    elif answerNumber == 3:
        return 'yes'
    elif answerNumber == 4:
        return 'Reply hazey try again'
    elif answerNumber == 5:
        return 'Ask again later'
    elif answerNumber == 6:
        return 'Concentrate and ask again'
    elif answerNumber == 7:
        return 'My replay is no'
    elif answerNumber == 8:
        return 'Outlook not good'
    elif answerNumber == 9:
        return 'Very doubtful'

print('Think of a yes/no question, and press enter to see the answer')
input()

print(getAnswer(random.randint(1, 9)))
    
