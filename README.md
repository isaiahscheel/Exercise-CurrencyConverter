# Currency Converter

This is a multi-part full-stack coding challenge where we will ask you to build a currency converter to use on alaskaair.com.

## Currency Converter API

The first part of the challenge will be to implement a Currency Conversion API that can convert an arbitrary amount of currency from one to another. 

We should be able to test this by hitting the endpoint: 
- `http://localhost:58414/api/currencyconverter?from=[fromCountryCode]&to=[toCountryCode]&amount=[Amount]`

So for example if we hit, `/currencyconverter?from=MXN&to=CAD&amount=10` we would expect the response to be the value of 10 Mexico Pesos in Canadian Dollars.

To get a list of currencies and conversion rates to support you can check `./CurrencyConverterLib/CurrencyConverterRepository.cs`.

The first part of the challenge is already partially implemented in the `CurrencyConverterLib` and `CurrencyConverterWebAPI` projects using .NET. Feel free to complete the .NET implementation of this API or use another technology that you prefer. 


## Currency Converter API Unit Tests

The next part of this challenge will be to test to your API to make sure it works as expected. 

If you decided to complete the .NET implementation you can choose to add more tests using the `CurrencyConverterLib.Tests` project. If you're using another technology, make sure to add unit tests to your API library.

Please add tests to sufficiency.

## Front End

The final part of this challenge will be to create a front-end that uses this API that you have just created. In the `UI` folder you will find bare sample projects using a variety of technologies to choose from.

Please choose one of these technologies and implement a front-end that allows a guest to choose any starting currency, any currency to convert to, and any amount of currency to convert. 

Here is a sample of what it can look like: 
![Currency Converter](./currency-converter.png)
But feel free to implement whatever design you would like.

We do however highly encourage you to use our custom Auro Design System to get any components or colors you may want to use: https://auro.alaskaair.com/getting-started/developers/common-definitions.

## What We're Looking For

- How efficient is the implementation?
- How is the implementation organized?
- How well is the code tested?
- How accessible is the front end?
