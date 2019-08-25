const add = (a,b) => a+b;
const generateGreetings = (name) => `Hello ${name}`;

test('should add two numbers', () => {
    const result = add(2,3);
    expect(result).toBe(5);
});


test('desired greeting string should be', () => {

    const result = generateGreetings('Patrik');

    expect(result).toBe(`Hello Patrik`);
});