Feature: UITest
	Search an existing Used Car listing with any relevant details like Keyword, Make, Model, Body Style

@ui
Scenario: Search an existing Used Car
	Given I opened the browser and navigated to trademe
	And I search an existing user car using reference 3909543812
	Then I verify the number plate is NRR378, kilometers as 60,378km, body Station Wagon, seats 7