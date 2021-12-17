import random
import requests
import json
import telebot

from KnowldgeBase import TELEGRAM_API_TOKEN, start_message, greetings, statuses, anecdotes,\
    stickers, YANDEX_WEATHER_API_TOKEN, yandex_weather_params, question_stikers, unclear_answers


class CoolTelegramBot:

    def __init__(self):
        bot = telebot.TeleBot(TELEGRAM_API_TOKEN)

        @bot.message_handler(commands=['start', 'help'])
        def send_welcome(message):
            bot.reply_to(message, start_message, parse_mode="Markdown")

        @bot.message_handler(regexp='привет|здавств|добр|ха+й|ку', content_types=['text'])
        def send_greeting(message):
            bot.send_message(message.from_user.id, self.__get_random_greeting())

        @bot.message_handler(regexp='как дела|как ты|дела|как сам', content_types=['text'])
        def send_greeting(message):
            bot.send_message(message.from_user.id, self.__get_randmon_life_status())

        @bot.message_handler(regexp='анекдот|расскажи|шутк', content_types=['text'])
        def send_weather(message):
            bot.send_message(message.from_user.id, self.__get_randmon_anecdot())

        @bot.message_handler(regexp='погод|прогноз', content_types=['text'])
        def send_weather(message):
            try:
                bot.send_message(message.from_user.id, self.__get_weather_forecast(), parse_mode="Markdown")
            except:
                bot.send_message(message.from_user.id, 'Не получилось достать погоду...')

        @bot.message_handler(content_types=['audio', 'photo', 'sticker', 'video'])
        def send_sticker(message):
            bot.send_sticker(message.from_user.id, self.__get_random_sticker())

        @bot.message_handler()
        def default_answer(message):
            bot.send_message(message.from_user.id, self.__get_unclear_answer())
            bot.send_sticker(message.from_user.id, self.__get_questioning_sticker())

        self.bot = bot

    def start(self):
        print('Bot is listening...')
        self.bot.infinity_polling()

    def __get_random_greeting(self) -> str:
        return random.choice(greetings)

    def __get_randmon_life_status(self) -> str:
        return random.choice(statuses)

    def __get_randmon_anecdot(self) -> str:
        return random.choice(anecdotes)

    def __get_random_sticker(self) -> str:
        return random.choice(stickers)

    def __get_questioning_sticker(self) -> str:
        return random.choice(question_stikers)

    def __get_unclear_answer(self) -> str:
        return random.choice(unclear_answers)

    def __get_weather_forecast(self) -> str:
        response = requests.get(
            url='https://api.weather.yandex.ru/v2/forecast',
            params=yandex_weather_params,
            headers={'X-Yandex-API-Key': YANDEX_WEATHER_API_TOKEN},
        )

        next_day_forecast = json.loads(response.text)['forecasts'][1]['parts']['day']

        return f"""
❄️️*Прогноз погоды на завтра*❄

Ожидаемая температура: *{next_day_forecast['temp_avg']}°C*
Погодные условия: *{next_day_forecast['condition']}* _(да-да...)_
"""


bot = CoolTelegramBot()
bot.start()
