@BeforeTweet @AfterTweet
Feature: TweetImage
	In order to give QAWorks an online presence on twitter
	I want to tweet an image

@mytag
Scenario: Tweet Image
	Given I have an image on my phone
	When I tweet the image with text "Test image QAWorks "
	Then I should see the image tweeted in my profile
