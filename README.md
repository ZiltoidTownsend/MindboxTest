<h2>Ответ на вопрос №2:</h2>
Из условия задачи ясно, что у таблиц продуктов и категорий связь "многие ко многим". Для реализации данной связи необходимо помимо основных таблиц с продуктами и категорий (Products и Categories, соответственно) создать промежуточную таблицу Products_Categories, которая будет хранить ссылки на записи из первых двух таблиц.
Запрос, позволяющий получить все пары «Имя продукта – Имя категории»:

    SELECT Products.name, Categories.name FROM Products
    LEFT JOIN Products_Categories ON Products.id = Products_Categories.products_id
    INNER JOIN Categories ON Categories.id = Products_Categories.category_id

