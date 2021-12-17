import random
import telebot
from pyowm import OWM

from BotLibrary import TELEGRAM_API_TOKEN, start_message, greetings, kak_dela_answers, anecdotes,\
    stickers, bad_question_answers

class НАСТЮХИН_БОТ:

    def __init__(self):
        bot = telebot.TeleBot(TELEGRAM_API_TOKEN)

        @bot.message_handler(commands=['start', 'help'])
        def send_start_message(message):
            bot.reply_to(message, start_message)

        @bot.message_handler(content_types=['text'])
        def say_hello(message):
            answer = self.process_text(message.text)
            bot.send_message(message.from_user.id, answer)

        @bot.message_handler(content_types=['audio', 'photo', 'sticker', 'video'])
        def send_sticker(message):
            bot.send_sticker(message.from_user.id, self.__get_random_sticker())

        bot.infinity_polling().0

    def process_text(self, text):
        if 'привет' in text or 'здравствуй' in text:
            return self.__get_random_greeting()
        elif 'как дела' in text or 'fdsaf' in text:
            return self.__get_randmon_life_status()
        elif 'расскажи анекдот' in text or 'расскажи шутку' in text or 'пошути' in text:
            return self.__get_randmon_anecdot()
        elif 'скажи погода' in text or 'погода' in text:
            return self.__get_weather_forecast()
        else:
            return self.__get_unclear_answer()

    def __get_random_greeting(self):
        return random.choice(greetings)

    def __get_randmon_life_status(self):
        return random.choice(kak_dela_answers)

    def __get_randmon_anecdot(self):
        return random.choice(anecdotes)

    def __get_random_sticker(self):
        return random.choice(stickers)

    def __get_unclear_answer(self):
        return random.choice(bad_question_answers)

    def __get_weather_forecast(self):
        owm = OWM('27d1eeeff6ac7195a71e13c18b6df6c7')
        mgr = owm.weather_manager()

        observation = mgr.weather_at_place('Moscow,RU')
        w = observation.weather

        return "Погода\n" + f"Температура: {w.temperature('celsius')['temp']}\n" + f"Общее: {w.detailed_status}"


bot = НАСТЮХИН_БОТ()
