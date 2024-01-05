// minha solução

function plusOne(digitos: number[]): number[] {
    let s: string = digitos.join("");

    let sum: BigInt = BigInt(s) + BigInt(1);

    let arr: number[] =  sum.toString().split("").map(Number);

    return arr;
}

// menor runtime

/*
function plusOne(digits: number[]): number[] {
    for (let i = digits.length - 1; i >= 0; i--) {
        if (digits[i] + 1 >= 10) {
            digits[i] = (digits[i] + 1) % 10;
        } else {
            digits[i] = digits[i] + 1;
            return digits;
        }
    }
    return [1, ...digits];  
};
*/