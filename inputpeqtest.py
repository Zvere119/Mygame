import tkinter as tk
import pyautogui as auto
import time
class Application(tk.Frame):
    def __init__(self, master=None):
        super().__init__(master)
        self.pack()
        self.create_widgets()

    def create_widgets(self):
        self.ss_test = tk.Button(self)
        self.ss_test["text"] = "To start the  test..\n(Please click on the arrow >)"
        self.ss_test["command"] = self.ss_start
        self.ss_test.pack(side="top")

        self.quit = tk.Button(self, text="QUIT", fg="red",
                              command=root.destroy)
        self.quit.pack(side="bottom")

    def ss_start(self):
        print("To stop test at anytime click on QUIT. Test starting.......")
        time.sleep(1)
#opens the input window and closes it.
        auto.moveTo(140, 225, duration= 1)
        auto.click(duration= 2)
        auto.moveTo(530, 250, duration= 1)
        auto.click(duration= 2)
        auto.moveTo(1170, 300, duration= 1)
        auto.click(duration= 1)
        time.sleep(1)
        auto.click(duration= 1)
        auto.moveTo(380, 370, duration= 1)
        auto.click(duration= 1)
        auto.moveRel( 45, 0, duration=.5)
        auto.click(duration= 1)
        auto.moveRel( 45, 0, duration=.5)
        auto.click(duration= 1)
        auto.moveRel( 45, 0, duration=.5)
        auto.click(duration= 1)
        auto.moveRel( 45, 0, duration=.5)
        auto.click(duration= 1)
        # high shelf and bell filter types and selects bell
        auto.moveRel( 400, 0, duration=.5)
        auto.click(duration= 1)
        auto.moveRel( 0, 70, duration=.5)
        auto.click(duration= 1)
        #enters different db values and then flattens
        auto.moveTo(1110, 375, duration= 1)
        auto.doubleClick(duration= 1)
        auto.doubleClick(duration= 1)
        auto.press('backspace')
        time.sleep(1)
        #needs a function of in range for different values
        auto.typewrite('-10', interval= .2)
        auto.press('enter')
        auto.click(duration= 1)
        
        #works towards bottom of peq filters freq and width
        auto.moveTo(1040, 780, duration= 1)
        auto.click(duration= 1)
        auto.moveTo(1130, 840, duration= 1)
        auto.doubleClick(duration= 1)
        auto.press('backspace')
        auto.typewrite('200', interval= .2)
        auto.press('enter')
        auto.moveTo(1130, 910, duration= 1)
        auto.doubleClick(duration= 1)
        auto.press('backspace')
        auto.typewrite('20', interval= .2)
        auto.press('enter')
        auto.moveTo(1020, 365, duration= 1)
        auto.click(duration= 1)


root = tk.Tk()
app = Application(master=root)
