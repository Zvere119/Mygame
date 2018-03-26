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
        self.ss_test["text"] = "Set resolution to 1280 x 1024 and expand the browser window.\nTo start the  test..\n(Please click on the arrow -->)"
        self.ss_test["command"] = self.ss_start
        self.ss_test.pack(side="top")

        self.quit = tk.Button(self, text="QUIT", fg="red",
                              command=root.destroy)
        self.quit.pack(side="bottom")

    def ss_start(self):
        print("To stop test at anytime click on QUIT. Test starting.......")
        time.sleep(1)

        auto.moveTo(25, 155, duration= 2)
        auto.click(duration= 2)
        auto.moveRel(0,50, duration= 2)
        auto.moveRel(50,0, duration= 1)
        auto.click()
        auto.moveRel(150,0, duration= 1)
        auto.click()
        auto.moveRel(100,0, duration= 1)
        auto.click()
        auto.moveTo(100, 195, duration= 1)
        auto.click(duration= 1)
        
     


root = tk.Tk()
app = Application(master=root)
