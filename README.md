# automation
General Style Guide:
. Selenium tests should generally avoid using extensive E2E tests.


Potential Improvements/ Technical Debt:
. If there was more time then a factory class that instantiates a variety of browser instances would have been created.


. Using a configuration repository that contains the websites locators. This helps with maintaining code, e.g if methods share locaters.

. A configuration variables file should have been used for the items that can be purchased. This allows better reuse of methods.

. Less XPath should have bee used. XPath can be very brittle.
