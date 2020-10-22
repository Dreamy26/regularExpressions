# Lab7 Regular Expressions

## Notes

## Task: learn how to write methods and regex 

## Methods - something that does some work for us/self contained actions/functions-reusable

### valid name - ValidName(string userName)
### valid email - ValidEmail(string userEmail)

### valid phone number - ValidPhoneNumber(int userPhoneNumber)

### valid date - in valid format - ValidDateFormat(int userDateInput)

### valid HTML - validHTML(string userHTMLInput)


## Classes

## User steps

1. User sees "Please enter a valid name"
2. program checks if valid or not, if not "Sorry, name is not valid!"
3. User sees " Please enter a valid email:"
4. program checks if valid, if valid "Email is valid!"
5. User sees, "Please enter a valid phone number:"
6. Program checks if phone number is valid, if not, "Sorry, phone is not valid!"
7. User sees, "Please enter a valid date:"
8. Program checks if date is in valid format, if not, "Sorry, date is not valid"


## Requirements

1. Write a method that will validate names.
- Name w/alphabets
- start with a capital letter,
- maximum 30 chars
- `([A-Z][a-z]{1,30})\b`

2. Write a method that will validate emails. 
- Format: {combination of alphanumeric characters, with a length between 5 and 30, and there are no special characters}
- @{combination of alphanumeric
characters, with a length between 5 and 10, w/no special characters}.
- {domain can be a combination of alphanumeric characters with a length of two or three}

3. Write a method that will validate phone numbers.
- {area code of 3 digits} - {3 digits} - {4 digits}
4. Write a method that will validate date based on the following format: (dd/mm/yyyy) 

## CSharp SoSharp

## Resources
[oreilly reg expressions](https://www.oreilly.com/library/view/regular-expressions-cookbook/9781449327453/ch06s07.html) 
[stackover flow regex gems](https://stackoverflow.com/questions/4374185/regular-expression-match-to-test-for-a-valid-year)


## Questions
