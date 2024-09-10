# Console Credit Risk - IT DEV RISK

Categorize trades in a bank´s portfolio example.

## Input
The first line of the input is the reference date. The second line contains an integer n, the number of trades in
the portfolio. The next n lines contain 3 elements each (separated by a space). First a double that represents
trade amount, second a string that represents the client’s sector and third a date that represents the next
pending payment. All dates are in the format mm/dd/yyyy.+

## Output
N lines with the category of each one of the n trades.

### Sample input
12/11/2020
4
2000000 Private 12/29/2025
400000 Public 07/01/2020
5000000 Public 01/02/2024
3000000 Public 10/26/2023

### Sample output
HIGHRISK
EXPIRED
MEDIUMRISK
MEDIUMRISK
