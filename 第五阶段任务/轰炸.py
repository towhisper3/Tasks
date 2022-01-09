import time
from pynput.keyboard import Key,Controller as key_cl
from pynput.mouse import Button,Controller as mouse_cl

def keyboard_input(string):
    keyboard = key_cl()
    keyboard.type(string)

def mouse_click():
    mouse = mouse_cl()
    mouse.press(Button.left)
    mouse.release(Button.left)

def send_message(number,string):
    print('程序将在3秒后运行')
    time.sleep(3)

    keyboard = key_cl()

    for i in range(number):
        keyboard_input(string)
        mouse_click()
        time.sleep(0.3)
        keyboard.press(Key.enter)
        keyboard.release(Key.enter)

if __name__ == '__main__':
    send_message(3,'hhh')