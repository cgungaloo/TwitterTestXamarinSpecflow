﻿@BeforeTweet @AfterTweet
Feature: TweetText
	In order to announce things about my life
	I want to send a tweet
	So I can feel amazing

Scenario: Send First Tweet
	When I send a the tweet "Test Tweet from QA Works "
	Then then I should see the tweet in my profile.

Scenario: Send Second Tweet
	When I send a the tweet "Test Tweet from QA Works "
	Then then I should see the tweet in my profile.