Feature: Products

As a user I want to buy products

@BuyProducts
Scenario: Buy a product
	Given I have logged in 
	And I add the 'Sauce Labs Bolt T-Shirt' to my cart
	Then I verify the product added
	| Product                 | Price  |
	| Sauce Labs Bolt T-Shirt | $15.99 |
	When I click the checkout button
	And I fill the form and I click the continue button
	| FirstName | LastName | Postal Code |
	| Victor    | Cisneros | 38940       |
	Then I verify the overview data
	| Product                 | Price  | PaymentInfo      | ShippingInfo                | Total         |
	| Sauce Labs Bolt T-Shirt | $15.99 | SauceCard #31337 | FREE PONY EXPRESS DELIVERY! | Total: $17.27 |
	And Click the Finish button
	Then I see the confirmation message
	| ConfirmationMessage                                                                     |
	| Your order has been dispatched, and will arrive just as fast as the pony can get there! |
