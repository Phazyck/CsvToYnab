# CsvToYnab
An application that reads CSV files and outputs corresponding OFX files for use in the YNAB budgeting application.

### Execution (CLI)
Simply call Export.exe with paths to the files you wish to convert, as arguments.

*Example:* `> Export.exe ATransaction.csv AnotherTransaction.csv TheLastTransaction.csv`
  
### Execution (GUI):
Simply drag the files you wish to convert and release them onto Export.exe.


### Configuration (GUI):
The conversion process can be configured by using Configure.exe.

Following is an explanation of each of the settings:

**Payee, Date, Amount, Memo, Check #:**

These indicate which column the software should look for the payee, date, amount, name and check number, in your CSV files, respectively.

The check-marks, indicate whether these columns will be included in the porting process or not.

**Comma Separators:**

This indicates what is used to separate entries in your CSV files.
Some CSV files use ";", while others use "," or tabs.
Any character entered here will be regarded as a comma-separator when reading the CSV.

**Skip Lines:**

In case your CSV files contains initial lines that do not contain actual data, such as titles and headers,
you can indicate how many of such lines should be skipped, by entering that number here.

**Date Format:**

Is used to tell the program how the dates in your CSV files are laid out.
For more info on this, see: https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx

**Number Decimal Separator:**

Is used to tell the program which character is used to separate the integral part from the decimal part.

E.g., in American locales, 5/2 can be written as 2.5, while in Danish, it can be written as 2,5.
Here, the NumberDecimalSeparators are "." and "," respectivly.

**Number Group Separator:**

Is used to tell the program which character is used to group together digits in the integral part of numbers.

E.g., in American locales, 100*100 can be written as 10,000, while in Danish, it can be written as 10.000.
Here, the NumberGroupSeparators are "," and "." respectivly.
