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
        
        for nephila_repeat in range(1,10):
            auto.moveTo(1127, 440 ,duration = .5)
            auto.click()
            auto.typewrite('test1', interval = .2)
            auto.moveTo(1131, 510 ,duration = 1)
            auto.click()
            auto.typewrite('test1', interval = .2)
            auto.moveTo(1291, 550 ,duration = 1)
            auto.click()
            auto.moveTo(20, 40 ,duration = 2)
            auto.click()
        return ( nephila_repeat)


   
        
      
    
        
     
   
root = tk.Tk()
app = Application(master=root)
app.mainloop()


 


