def main():
    n = int(input("Enter a number: "))
    print("The nth number in fibonacci series is:", fib(n))


def fib(n):
    if n == 0 or n == 1:
        return 1
    return fib(n - 1) + fib(n - 2)


main()
