# Решение
1. Первым этапом предлагаем пользователю ввести *длину массива*;
2. Затем, при помощи цикла *for*, программа предлагает пользователю ввести по очереди все элементы массива;
3. Если среди элементов, введенных пользователем, нет элементов с количеством симоволов менньшим, либо равным **трём**, программа завершается. Если такие элементы есть, снова при помощи цикла *for* считаем количество этих элементов для определения длины нового массива;
4. Когда длина нового массива определена, циклом *for* проходим по всем элементам старого массива и, если длина элемента меньше либо равна **трём**, записываем этот элемент в новый массив.