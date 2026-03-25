
![Python](https://img.shields.io/badge/Python-3776AB?logo=python&logoColor=white&style=flat)
![Django](https://img.shields.io/badge/Django-092E20?logo=django&logoColor=white&style=flat)
![Django REST Framework](https://img.shields.io/badge/DRF-red?logo=django&logoColor=white&style=flat)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-4169E1?logo=postgresql&logoColor=white&style=flat)
![Docker](https://img.shields.io/badge/Docker-2496ED?logo=docker&logoColor=white&style=flat)
![Nginx](https://img.shields.io/badge/Nginx-009639?logo=nginx&logoColor=white&style=flat)
![Workflow](https://github.com/owl-ik/foodgram/actions/workflows/main.yml/badge.svg)

# FoodGram

**Сайт с рецептами, создавай рецепты, подписывайся на других участников, будь счастлив в мире кулинарии! Сайт проекта: https://topfaearwer.online**

## Запуск проекта локально

### Клонируйте репозиторий:
```
git clone https://github.com/owl-ik/foodgram
```

### Создайте в корне папки файл .env и заполните его. (env_base_and_superuser.txt)

### Запуск в контейнерах Docker:
```
cd foodgram
sudo docker compose up
```

### Создайте миграции и соберите статику в контейнере backend:
```
sudo docker compose exec backend python manage.py migrate
sudo docker compose exec backend python manage.py collectstatic
sudo docker compose exec backend cp -r /app/collected_static/. /static/static/    
```

### Загрузите ингредиенты и тэги:
```
# Загрузка ингредиентов из CSV (по умолчанию data/ingredients.csv)
sudo docker compose exec backend python manage.py load_ingredients data/ingredients.csv

# Загрузка тегов из JSON
sudo docker compose exec backend python manage.py load_tags data/tags.json

# Если файлы находятся в стандартной папке data/, можно использовать короткие команды:
sudo docker compose exec backend python manage.py load_ingredients
sudo docker compose exec backend python manage.py load_tags
```


## Документация API

- **Redoc**: [http://localhost/redoc/](http://localhost/redoc/) (после локального запуска)

## Основные эндпоинты API

### Аутентификация
- `POST /api/auth/token/login/` - Получене токена
- `POST /api/auth/token/logout/` - Удаление токена

### Пользователи
- `GET /api/users/` - Список пользователей
- `POST /api/users/` - Регистрация пользователя
- `GET /api/users/{id}/` - Профиль пользователя
- `GET /api/users/me/` - Текущий пользователь
- `POST /api/users/set_password/` - Изменение пароля

### Рецепты
- `GET /api/recipes/` - Список рецептов (с фильтрацией)
- `POST /api/recipes/` - Создание рецепта
- `GET /api/recipes/{id}/` - Получение рецепта
- `PATCH /api/recipes/{id}/` - Обновление рецепта
- `DELETE /api/recipes/{id}/` - Удаление рецепта

### Избранное
- `POST /api/recipes/{id}/favorite/` - Добавить в избранное
- `DELETE /api/recipes/{id}/favorite/` - Удалить из избранного

### Список покупок
- `POST /api/recipes/{id}/shopping_cart/` - Добавить в корзину
- `DELETE /api/recipes/{id}/shopping_cart/` - Удалить из корзины
- `GET /api/recipes/download_shopping_cart/` - Скачать список покупок

### Подписки
- `GET /api/users/subscriptions/` - Мои подписки
- `POST /api/users/{id}/subscribe/` - Подписаться на пользователя
- `DELETE /api/users/{id}/subscribe/` - Отписаться от пользователя

### Теги
- `GET /api/tags/` - Список тегов
- `GET /api/tags/{id}/` - Получение тега

### Ингредиенты
- `GET /api/ingredients/` - Список ингредиентов (с поиском)
- `GET /api/ingredients/{id}/` - Получение ингредиента

# Автор
- https://github.com/owl-ik

![Python](https://img.shields.io/badge/Python-3776AB?logo=python&logoColor=white&style=flat)
![Django](https://img.shields.io/badge/Django-092E20?logo=django&logoColor=white&style=flat)
![Django REST Framework](https://img.shields.io/badge/DRF-red?logo=django&logoColor=white&style=flat)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-4169E1?logo=postgresql&logoColor=white&style=flat)
![Docker](https://img.shields.io/badge/Docker-2496ED?logo=docker&logoColor=white&style=flat)
![Nginx](https://img.shields.io/badge/Nginx-009639?logo=nginx&logoColor=white&style=flat)
![Workflow](https://github.com/owl-ik/foodgram/actions/workflows/main.yml/badge.svg)

# FoodGram

**Сайт с рецептами, создавай рецепты, подписывайся на других участников, будь счастлив в мире кулинарии! Сайт проекта: https://topfaearwer.online**

## Запуск проекта локально

### Клонируйте репозиторий:
```
git clone https://github.com/owl-ik/foodgram
```

### Создайте в корне папки файл .env и заполните его. (env_base_and_superuser.txt)

### Запуск в контейнерах Docker:
```
cd foodgram
sudo docker compose up
```

### Создайте миграции и соберите статику в контейнере backend:
```
sudo docker compose exec backend python manage.py migrate
sudo docker compose exec backend python manage.py collectstatic
sudo docker compose exec backend cp -r /app/collected_static/. /static/static/    
```

### Загрузите ингредиенты и тэги:
```
# Загрузка ингредиентов из CSV (по умолчанию data/ingredients.csv)
sudo docker compose exec backend python manage.py load_ingredients data/ingredients.csv

# Загрузка тегов из JSON
sudo docker compose exec backend python manage.py load_tags data/tags.json

# Если файлы находятся в стандартной папке data/, можно использовать короткие команды:
sudo docker compose exec backend python manage.py load_ingredients
sudo docker compose exec backend python manage.py load_tags
```


## Документация API

- **Redoc**: [http://localhost/redoc/](http://localhost/redoc/) (после локального запуска)

## Основные эндпоинты API

### Аутентификация
- `POST /api/auth/token/login/` - Получене токена
- `POST /api/auth/token/logout/` - Удаление токена

### Пользователи
- `GET /api/users/` - Список пользователей
- `POST /api/users/` - Регистрация пользователя
- `GET /api/users/{id}/` - Профиль пользователя
- `GET /api/users/me/` - Текущий пользователь
- `POST /api/users/set_password/` - Изменение пароля

### Рецепты
- `GET /api/recipes/` - Список рецептов (с фильтрацией)
- `POST /api/recipes/` - Создание рецепта
- `GET /api/recipes/{id}/` - Получение рецепта
- `PATCH /api/recipes/{id}/` - Обновление рецепта
- `DELETE /api/recipes/{id}/` - Удаление рецепта

### Избранное
- `POST /api/recipes/{id}/favorite/` - Добавить в избранное
- `DELETE /api/recipes/{id}/favorite/` - Удалить из избранного

### Список покупок
- `POST /api/recipes/{id}/shopping_cart/` - Добавить в корзину
- `DELETE /api/recipes/{id}/shopping_cart/` - Удалить из корзины
- `GET /api/recipes/download_shopping_cart/` - Скачать список покупок

### Подписки
- `GET /api/users/subscriptions/` - Мои подписки
- `POST /api/users/{id}/subscribe/` - Подписаться на пользователя
- `DELETE /api/users/{id}/subscribe/` - Отписаться от пользователя

### Теги
- `GET /api/tags/` - Список тегов
- `GET /api/tags/{id}/` - Получение тега

### Ингредиенты
- `GET /api/ingredients/` - Список ингредиентов (с поиском)
- `GET /api/ingredients/{id}/` - Получение ингредиента

# Автор
- https://github.com/owl-ik
