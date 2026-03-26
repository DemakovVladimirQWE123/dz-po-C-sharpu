const readline = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout
});

function calc(x) {
    if (x < 0) return 120 / (-x);
    return x / (45 - x);
}

readline.question('Введите начальное целое число от -5 до 5: ', input => {
    const start = parseInt(input);
    if (isNaN(start) || start < -5 || start > 5) {
        console.log('Некорректный ввод. Должно быть целое число от -5 до 5.');
    } else {
        for (let x = start; x <= 5; x++) {
            console.log(`x = ${x}, y = ${calc(x)}`);
        }
    }
    readline.close();
});
