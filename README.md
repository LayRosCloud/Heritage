# Диздок по игре "Heritage"

## Содержание

- [Краткая характеристика](#краткая-характеристика)
- [Глоссарий](#глоссарий)
- [Синопсис](#-синопсис)
- [Управление](#-управление)
- [Сеттинг игры](#-сеттинг-игры)
- [Системы и механики](#системы-и-механики)

## Краткая характеристика
- **Жанры**: _ролевая игра, стратегия, приключение, аркада, выживание_, выглядит как Point clicker -- 
(примеры таких игр будут являться 
[Reigns](https://store.steampowered.com/app/474750/Reigns/), 
[60 seconds](https://store.steampowered.com/app/368360/60_Seconds/))

## Глоссарий

- **Карточка** - элемент игры, который описывает произошедшее событие.
- **Геймплей** - совокупности механик, который дарят игроку игровой опыт.
- **Контроллируемая удача** - Проценты выпадения какого-либо события редактируются тем в каком положении игрок находится
в текущий момент
- **Система** - глобальная "механика", которая дейстствует всегда, лишь иногда ограничиваясь какой-либо другой системой.
- **Механика** - действие, которое работает лишь в определенных условиях.
- **Бафф** - какой-либо параметр или действие, который помогает игроку в прохождении игры
- **Дебафф** -  какой-либо параметр или действие, который мешает игроку в прохождении игры

## 🔖 Синопсис
> Синопсис - это краткое описание игры, без захода в детали

Это игра о том как человек оказался на окраине средневекового мира, где он должен банально выжить максимальное количество 
дней. Каждый день игрока будут встречать несколько [карточек](#глоссарий), который будут либо усложнять, либо упрощать 
[геймплей](#глоссарий), в зависимости от удачи.

## 🎮 Управление

Кнопка по активации какого-либо элемента (сокращенно Кл. д.) - Нажатие по экрану пальцем 👉🏼

| Наименование действия           | Клавиша |
|---------------------------------|---------|
| Нажатие по кнопке               | Кл. д.  |
| Зажал на слайдере для музыки    | Кл. д.  |
| Нажал на элементе игрового мира | Кл. д.  |

## 📖 Сеттинг игры
Мир состоит из 3 локаций: 
- [x] _Двор дома_ (главная локация), 
- [x] _внутреннее устройство дома (ВУД)_
- [ ] _лес_, 

**Двор дома** - центральная локация, которая связывает между собой все локации, на неё будет приезжать повозка с провизией, 
и из неё можно будет попасть в лес, либо в ВУД. Можно так же использовать некоторые активности (посадить огород)

На интерфейсе игры на главной локации будут 3 кнопки и один элемент управления:
- [x] Все действующие карточки
- [x] Пропуск дня (часы)
- [x] Отображенияы количества монет
- [ ] кнопка открытия главного меню (пауза)

На локации ВУД интерфейс выглядит следующим образом:
- [x] есть кнопка открытия инвентаря
- [x] отображения сколько у игрока единиц воды, еды, дров.

На локации лес, не будет много интерфейса, но будут мини-игры.

Мир "_open world_" - можно пойти куда угодно и когда угодно.

Игрок будет перемещаться с помощью нажатий по элементам мира.

Примеры стилистики (общие черты - это low poly вектор с острыми краями):

![Пример стилистики](https://i.pinimg.com/736x/bf/fc/b1/bffcb142df1acb55e84a6e0bc65ba254--haku-low-poly.jpg)
![Пример стилистики](https://img.freepik.com/premium-photo/a-low-poly-game-with-a-forest-scene_860805-4283.jpg)
![Пример стилистики](https://previews.123rf.com/images/tele52/tele521612/tele52161200004/67971480-isometric-low-poly-farm-elements.-farm-buildings,-vehicles-included,-fields-with-plants-and-fence.jpg)
![Пример стилистики](https://i.pinimg.com/originals/3c/eb/41/3ceb410e68d3d0dc008b6352c7704e26.jpg)
![Пример стилистики](https://thumbs.dreamstime.com/b/vector-%D0%BD%D0%B8%D0%B7%D0%BA%D0%B8%D0%B5-%D0%BF%D0%BE-%D0%B8-d-%D0%B7-%D0%B0%D0%BD%D0%B8%D1%8F-%D0%B8-%D1%81%D1%86%D0%B5%D0%BD%D0%B0-%D0%B3%D0%BE%D1%80%D0%BE-%D0%B0-93734804.jpg)

## Системы и механики
> Сначала будут затронуты все системы, после уже механики
___
### Карточки
> Основная суть системы "[Карточки](#глоссарий)" (от определения в глоссарии) это появления элемента "[Карточка](#глоссарий)",
которая будет информировать игрока о том что с его персонажем случилось какое-либо событие.

- ВС - карточка может выпасть на столе.
- ВМ - карточка может выпасть в мире
- ВР - карточка может выпасть после <наименование карточки>
- НВ - карточка не может вызваться после <наименование события>
- Л - легендарная карта, действует продолжительное время, вызывает событие.
- П - пассивная карта, действует продолжительное время, может менять параметры.
- С - событийная карта, вызывается моментально, вызывает событие.

#### [Механики системы](#глоссарий)
- [x] После нажатия кнопки "Часы", появляется стол, с помощью анимации спавнятся 3 карты. (мех. карт. 1)
- [ ] Появление карты зависит от условий. Для появления некоторых карточек необходимы особые условия.
- [x] Каждая карточка имеет особое влияние на мир игры.
- [ ] При нажатии на карточку показывается описание
- [ ] [Контроллируемая удача](#глоссарий)

##### Все карточки
| Имя карточка | Описание |
- [ ] Случайный прохожий - ВС, ВМ (только в лесу), ВР <Некоторые карты открывают персонажей> С, вызывается "Случайный персонаж" с диалогом. НВ <как персонажи кончатся>. 
Персонаж спавнятся возле дома. После нажатия по нему, открывается диалог, если игрок нажмет по нему ещё раз, начнется 
следующий диалог.
- [ ] Простреленно колено - ВМ, ВР <разбойники> П. Нельзя делать действие "Посадить огород" и "Добыть дрова"
- [x] Черная карточка (маскировка для карт) - ВР <Слепота> П. Прячет за собой все карты, кроме карты "Слепота"
- [x] Слепота - НВ <есть Слепота> ВС П, маскирует все карты на черную карточку, на N время
- [x] Красноречие - ВС П, снижает все цены в магазине на N процент
- [x] Гроза - ВР <Дождь> С, забирает N дерева и M воды.
- [x] Дождь - ВС П, вызывает Дождь, открывает возможность другим картам
- [ ] Сообщение - ВС С, отображает текст, становятся доступны некоторые персонажи, которые могут прийти. Присутствует 
выбор Подписать, отказать
- [x] Лужа - ВР <Дождь ВС> , увеличивает затратность каждого действия на N время. 
- [x] Крыса - ВС НВ <выпал Волк> С, игрок теряет N еды.
- [x] Сокровище - ВМ С, дает игроку N золота
- [ ] Война - ВС Л, вызывает глобальное событие Война, действует X дней. Затрачивание ресурсов увеличивается на X. 
Открывает новых персонажей: "Воин", "Рыцарь".
- [ ] Волк - ВС НВ <выпала Крыса>, обнуляет еду, если еда уже была 0, игрок проигрывает
- [ ] Дом поле-бое - ВР<Война> Л, затрачивание ресурсов увеличивает в X раз
- [ ] Потеря конечности - ВР<Дом поле-бое> ВР<Заражение раны> Л, на N время отпадает способность делать действия по добычи
ресурсов
- [ ] Алкоголизм - ВС, ВМ, ВР <Сильные эмоции> С, время пропускается на N часов, игрок может оказаться в незнакомой локации. Ему придет
сообщение, вы оказались в X локации, время на возращение займет ещё G часов.
- [ ] Сильные эмоции - ВМ, ВС, ВР <Взаимоотношения с людьми> П, время на действия меняет на N минут в зависимости от ситуации.
- [ ] Грибы - ВМ, ВР <Вы добыли еду в лесу> С, Игрок не можете делать действия, заменяются некоторые спрайты: "Повозка", "Дом", "Саженцы", 
открываются новые персонажи: "Пугало"
- [ ] Заражение раны - ВР <Прострелили колено> Л, увеличивает затрачивание времени X часов, пропадает через N время
- [ ] Предмет Лекарство - убирает эффект Заражение раны. Стоит X монет
- [ ] Чума - ВС Л, открывает нового персонажа: "Чумной доктор"
- [ ] Заражение чумой - ВР <Чума> П, увеличивает затрачивание времени в X раз, персонаж умирает через N дней
- [ ] Излечение чумой - ВР <Заражение чумой> С, убирает эффект Заражение чумой.
- [ ] Розовые очки - ВР<Случайный прохожий>. Открывается персонаж для взаимоотношений (дама сердца).
- [ ] Семя жизни или смерти - ВМ, Игрок получает неизвестный вид семян
- [ ] Открытие картошки - ВР<Семя жизни или смерти> Л. Игрок открывает неизвестный вид съедобного продукта. Дает возможность дорогой продажи, карточка можно продать N монет
- [ ] Отравление - ВР<Семя жизни или смерти> П. Персонаж отравляется, затрачивание времени увеличино на N часов. 
Эффект спадет через X дней.
- [ ] Розовые очки въелись - ВР<Розовые очки> П. вызывается с A% Карточка <сильные эмоции>. Затрачивание
времени снижается на Z время. 
- [ ] Розовые очки спали - ВР<Розовые очки> П. Вызывается карточка <Сильные эмоции>. Затрачивание
  времени повышается на Z время. 
___
### Время
> Система "Время" - работает без каких-либо условий, каждое действие занимает N время от дня персонажа

Д - Игрок делает действие "Ваше действие" у него это занимает N время
#### [Механики системы](#глоссарий)
- [x] Д "Посадить огород"
- [ ] Д "Взять с огорода <овощь>"
- [ ] Д "Добыть дерево в лесу"
- [ ] При достижении лимита времени, автоматически идем на новый день
___
### Сохранение/Загрузка
> Система "Сохранение/Загрузка" - позволяет игроку сохранить свой прогресс, выйти из игры, зайти в игру и загрузить свое
> последнее прохождение. 

Должны сохраняться параметры: 
- [ ] "Количество монет"
- [ ] "Количество пищи"
- [ ] "Количество воды"
- [ ] "Количество дерева"
- [ ] Всех "случайных прохожих", кто у нас уже был
- [ ] Настройки: "Выбранный язык", "Ползунки звука", "other parameters"
- [ ] Инвентарь: инструменты, на какой странице инвентаря они находятся, так же обычные объекты
- [ ] Все карточки, которые у нас находятся пассивно
___
### Меню
> Главное меню содержит кнопки: "Продолжить", "Новая игра", "Настройки", "Выйти";

Продолжить - загружает последнее сохранение и запускает сцену с игрой

Новая игра - стирает сохранение и запускает сцену с игрой

Настройки - открывает окно, которое позволяет настроить звук, некоторую графику, лимит фпс.
___
### Система единиц
> Хранит в себе шкалы дерево, вода, еда, если какая-то из шкал отрицательная, то игрок умирает.
- [x] Монеты хранятся в мешке.
- [ ] Если монета выпала из мешка, то она пропадает.
- [ ] Воду можно взять из реки
- [ ] Еду можно купить, если у игрока есть оружие, он может победить животное и тем самым добыть еду.
- [ ] В битве преследуется пошаговая боевка

![пример](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTmpbaU-EwAIQOvjfdX6GKBXMG883EW58EB59MPQxBB24fnx2RdjKZXlxEpXgB2EszrIV4&usqp=CAU)
![пример](https://i.ytimg.com/vi/aQe1QXjISNQ/maxresdefault.jpg)

- [ ] Дерево можно добыть в лесу, будет мини игра, в которой надо попадать в ритм.
- [ ] Если игрок промахивается, то ему выпадает какая-то негативная карточка

![ритм игра](https://irecommend.ru/sites/default/files/imagecache/copyright1/user-images/519437/zvCr0jdRiwwzhSpmNlSkQ.jpg)
___
### Локализация
> Хранит переводы в формате и в зависимости от выбора в настройках переводит все элементы с текстом на тот, который выбрал
> игрок
- [ ] Хранение в формате JSON
```json
[
  "ru": {
    "card-1": {
      "name": "Наименование",
      "description": "Описание"
    },
    "card-2": {
      "name": "Наименование",
      "description": "Описание"
    },
    "card-3": {
      "name": "Наименование",
      "description": "Описание"
    }
  },
    "en": {
        "card-1": {
            "name": "Наименование",
            "description": "Описание"
        },
        "card-2": {
            "name": "Наименование",
            "description": "Описание"
        },
        "card-3": {
            "name": "Наименование",
            "description": "Описание"
        }
    }
]
```
___
### Магазин
> Магазин приезжает в зависимости от шанса, в нем можно купить 3 любых предмета, который он привезет
- [ ] [Контроллируемая удача](#глоссарий).
- Продажа вещей. Игрок может продасть A различных вещей за один день. Цена продажа снижена в X раза от исходной. При
карте красноречие, цена продажи увеличина в G раза от исходной.


### Другие
#### Диалоговая система
- [x] Появление букв
- [x] Поддержка Rich text
- [x] Поддержка выбора
- [ ] У каждой буквы звук


## Параметры
