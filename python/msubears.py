def main():
    for i in range(1, 101):
        if i % 15 == 0:
            print("MSUBears")
            continue
        if i % 3 == 0:
            print("MSU")
            continue
        if i % 5 == 0:
            print("Bears")
            continue
        print(i)


main()
