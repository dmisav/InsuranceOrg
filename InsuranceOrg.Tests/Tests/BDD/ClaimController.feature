Feature: ClaimController
  As a user
  I want to be able to post claims
  So that I can manage insurance claims

  Scenario: Posting a valid claim
    Given a valid claim with details
    When I post the claim
    Then the response should indicate success