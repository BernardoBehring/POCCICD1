Feature: Weather Forecast
    As a user, I want to retrieve the weather forecast for the next five days

Scenario: Retrieve Weather Forecast
    Given a user requests the weather forecast
    When the weather forecast is retrieved
    Then the user should receive the weather forecast for the next five days
