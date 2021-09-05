def main():
    file = open("ff.txt", "r")
    first = file.readline().strip()
    if "bear" in first:
        print("There is a 'bear' in first line of the file.")
    else:
        print("There is no 'bear' in the first line of the file.")
    file.close()


main()
