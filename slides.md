---
layout: cover
---

# Unlocking Hidden Efficiency
## Seamless Solutions with TDD You Didn't Know You Needed

<!-- 
Test Driven Development has largely being dismissed by large swaths of developers, and in some cases, it's applied 
without a clear understanding of when and how to use its varying styles effectively. 
In this session I will go into the origins TDD and how you can fully leverage its powers become a better developer. 

But first of all, who am I?
-->

---

## About Me

Michael Crook
Full-stack dotnet Contractor

- bsky.app/profile/mcrook.com
- linkedin.com/in/falconmick
- github.com/falconmick

<!--
Hi
I’m Michael!
I am a full stack dotnet contractor from Perth who spends his days working with dotnet to help plumb up all things
data from across my teams many data sources.
I would like to see myself as an overly passionate tech nerd who can’t stop getting excited about all things code and hardware, 
You can find me under the handle falconmick just about everywhere where I talk mostly about coding and console modding.

Throughout my career with all the teams I have had the opportunity to work with I have found the following to always be
true: If you want to deliver high quality software testing your code is without a doubt the key deciding factor on
how likely you are to succeed. It is not the quality or quantity of developer that matters, but instead the discipline that the
team takes to ensure they validate their code with tests that can be run with as minimal friction in both speed and 
resilience to change.
-->

---

## Question Time

<!--
Before I start lets do a theoretical:
The upper management is in a flurry, Product Y that our company produces's top competitor Product X has just announced
AI chat-bot integration, a game changing feature that is going to send our company broke if we cannot match or beat
their announced delivery date.

In this project speed matters above all else, we have been promised that as soon as we get this live we will be given
the time needed to go back around and clean up the implementation.

So the question for the audience: 
Hands down if we push back on our teams standard testing standards for the sake of the project
OR
Hands up if we deliver the code with our standard and some would argue rather rigorous testing practices?

=== delay for hands ===

By the end of this presentation I hope to have as many hands in the air when I ask this question again for all the
reasons that I have coming up but it all boils down to one law of delivering software:

# Slow is Smooth. Smooth is Fast

Fun fact: Audience participation varies greatly from country to country and Australia typically is on the more stone
faced side! You all fell for my trap card, now when we reach the end if all goes well I will look like I have converted 
the entire room!

My ego can't wait


-->

---

## Before we ask what, we ask why?

<!--
Now before I start going over the basics of what testing is I thought it might be best to go over why?
More specifically why did I get sucked into the world of testing in the first place!

Like most of you I started out with a surface level appreciation but at the same time a slight disdain for tests. 
After spending the last day or two on my PR and seeing that my 60% coverage was not acceptable to our automated
code coverage Pull Request tool was the very last thing I wanted to see at 5pm on Friday.

Nevertheless, I would work late and add some basic tests that would cover all the new code, check in my PR and head
home late for the weekend. It didn't help my morale when I came in on monday and the first thing I see is a PR with an
obvious bug in it that made it feel like I shouldn't have bothered staying late as my PR is now going to take a hot
minute to fix and by then all the other developers will be busy working on their changes so my code won't get another 
review until lunch.

At times like this it can feel like test are there purely to make Sonar Qube happy and not to make my codebase any better.
Not much good that tests was when It didn't even end up catching anything important.

I had my fair share of experiences like this up until one day when I was on a new team and I had the great opportunity to
work with a seasoned veteran of the London School of Test Driven development overseeing the tech at my new employer. Having
spent the majority of his career working on software for the stock exchange in england he was in and around all of the 
thought leaders of the London School of Test driven development as those ideas were first maturing.

=-=-=-= todo: improve =-=-=-= need to give actual origins and be sure theyre right
A question you might all have now is, what is this London school and what's it doing in this testing talk? Well that
is to do with the origins of the two main approaches to test driven development, the original classist approach known
as the Detroit school of test driven development and the London school which is the mockist approach.
=-=-=-==-=-=-==-=-=-==-=-=-=-

But more about that later, back to my new job working with this seasoned veteran:

When I first joined the team we were still scaling out the team, as of such we were lucky enough to be in a phase of
maintenance with the bigger jobs on the horizon I was able to have some wisdom departed upon me, the most important
of which being
-->

---

# RED
# GREEN
# REFACTOR

<!--

RED
GREEN
REFACTOR

It doesn't matter what kinda of approach you take to test driven development, this one will remain consistent among them
all. 
-->

---

# RED

<!--

First you write a test that will fail, it should be small and easy to write. 
It doesn't even have to compile, red can refer both to the test status bar or the syntax error caused by
the non-existent piece of code your test is referring to.
=== show the test with squigly: it('Should sum 2 plus 2 to equal 4', () => sum(2, 2).toEqual(4))
-->

---

# GREEN

<!--

Now we need to make that test work with the minimal amount of changes as possible
all sins permitted, was your test that two plus two equals four? Great stub out the method with
the two arguments of the augend and the addend and return four. 

=== transition in solution that shows var sum = (augend, addend) => 4 ===
It does not matter that our implementation is obviously wrong, that is 100% ok!
If you can look at an implementation and see that it is flawed that is a sign that you do not have
enough tests yet, and you need to continue the red green refactor cycle until you come to a more concrete output.
This approach is known as stutter testing and can often be used in conjugation with triangulation approaches.
-->

---

# REFACTOR

<!--
Refactor is a key part of the "design" part of test driven design. If you have been following TDD correctly
your solution will be as minimalistic as possible. Does the world's most understandable and maintainable code
come into existence for free? Normally not, the refactor stage is to make code that you feel comfortable checking in 
typically these changes are small, like extracting a method or variable to provide extra context through the name we 
decide to give that extracted code but can also be moderately complicated as such as for each loop into a linq statement.
The only condition is that once your refactor step is complete that all your test remain green as you may not implement
new code that is not fist covered by the creation of a failing test.
As a side note, your tests code is just as important as your production code. If there is duplication inside of your 
tests that could be solved with refactoring, it is at the time in which your codebase is green that you can apply
these fixes and should be keep up with as much rigor as your working code.
-->

---

# Mocking

<!--
Another tool that was instilled upon me was mocking, in particular extensive mocking.

Mocking sounds like a simple subject but depending on how you approach it you can get vastly different approaches to 
test driven design. 

One such approach is creating a new concrete implementation of an interface that is injected into your codebase that
was designed purely for testing say for example a mock implementation of your databases repository interface. By implementing
the provided interface you can either fully or partially re-create the methods which make external calls which cannot be 
reliably created from within the context of testing as in-memory version, allowing for easy test data setup as we own the
implementation and simplistic data access implementations on the getter/update endpoints the repository exposes.

This is often seen with inside out development through Detroit School or classicist blackbox style testing. In such solutions we 
strive to test code as close to realistic settings as we can, we still might be testing more internal layers to our codebase
but we aim to keep the executing code that we are testing as fully fledged as possible.

A second approach is to rely upon a mocking framework as such as Moq, fake it easy or nsubstitute in the world of languages like
C#. These tools allow for expression to be written which get called in place of the interface or class, allowing us to
define inline to our test what that call will return OR even allow us to assert that the call was made at all.

A word of caution here, most of these frameworks will provide tooling that allows you to implement mocks of concrete, 
implementations as such as classes in C# 
however do note that these are limited quite often to virtual or abstract methods and even if they are not
they can carry the risk of causing unrelated broken tests which are painful to fix.

If your language of choice has a way to define the contract of your classes through ideas as such as interfaces in C# it is
always best practice to do so, or at worst configure your mocks such that any un-mocked interaction with the substitute
that your mock is defining will return a default or null value as to completely remove any concrete implementation details 
from the execution of your tests. C# is perfect for this, but I have had a harder time in some more loose languages
like javascript. Discipline is your friend here.

These style mocks can also be used in Detroit School or classicist blackbox style tests, but they truly shine in the approach
my mentor was instilling upon me, the London School or mockist outside in approach. When we are following this approach
The one and only reason why a test should be failing is that the unit of work we are testing, 
the method or function or whatever you want to call it
is the only reason why that test should have failed. The implementation of the CartService does not concern our test,
all that matters is the contract it exposes to us, AddToCart which gave us arguments of itemId and quantity and it's
result of boolean. Our test will mock CartService fully and our assertions will ensure that when CartService's 
AddToCart returns false, that the AlertService is called with InformUser, and that the string argument message
has unable to add item to cart provided to it. 

We will go further into the Detroit and London school and their pros and cons later, but to continue with the
tools I was given for my assignment we have one last rather unique concept.
-->

---

# Adapters

<!--
The adapter pattern is not too strict of an idea, in that third party code instead of being directly relied upon, is 
instead abstracted away by an adapter layer, which can and often will help remove implementation details from our
dependant codebase, say for example our adapter might provide a getter for the third party that both sets up a
factory provided by the third party and then executes it all under the much simpler and relevant getter pattern.

It is just important that this layer remain as simplistic as possible as it can often not be viable to test outside 
of integration testing, so if your adapter grows too far you will end up having dangerously uncovered code.

In the case of the code that was being developed for the company I was working for at the time, the use of adapters
was alot more extreme than you might expect, we even adapted out DateTime, which gave our tests the ability to act as
Pure functions which allowed us to have much less brittle testing and also made testing edge cases a cakewalk as we had
full control over how much the time changes between each call to Now. When I go over a detailed example of how I think
TDD should be implemented in my C# example I will dig into this further.

// todo: from there go over the application that took files from one location, read them, then moved
// todo: them based upon information inside of the file to the correct location and how it worked
// todo: first time without flaw on the entire dataset. Normally this would have been allot harder.
-->

---

## Opening Statements (5 minutes)

- **Relatable anecdote or question:**
    - Example: "How many of you have felt the pain of spending days on a ticket, only to realize it could have been broken down into smaller, more manageable pieces?"
    - Share a personal story about how TDD transformed your workflow or mindset.

<!--

-->

---

- **Current state of TDD:**
    - Misunderstood, dismissed, or misapplied.
    - Gap in knowledge about its styles (Detroit vs. London).

- **Set expectations:**
    1. Origins and two schools of TDD.
    2. Strengths and weaknesses of each approach.
    3. Deep dive into leveraging one approach in C#.

- **Teaser:**
    - "By the end of this talk, you’ll walk away with actionable insights that could save you days of work and fundamentally change how you approach coding."

---

## Section 1: The Origins and Two Schools of TDD (10 minutes)

- **Brief history of TDD:**
    - Origins: Kent Beck, Extreme Programming.
    - Core philosophy: "Red-Green-Refactor."

- **Detroit School (Classic TDD):**
    - State-based testing.
    - Simplicity and minimalism.
    - Example: Testing a calculator app.

- **London School (Mockist TDD):**
    - Behavior-based testing and mocking dependencies.
    - Emphasis on design and collaboration.
    - **Critical point:** London allows for breadth-first development, enabling faster iteration and parallelization of work.
    - Example: Testing a service layer with mocked dependencies.

- **Transition:**
    - "Understanding their strengths and weaknesses is key to unlocking TDD’s full potential."

---

## Section 2: Strengths and Weaknesses of Each Approach (10 minutes)

- **Detroit School (Classic TDD):**
    - **Strengths:**
        - Simplicity and readability.
        - Great for algorithmic or state-heavy logic.
        - Encourages minimalistic design.
    - **Weaknesses:**
        - Tightly coupled code if not careful.
        - Less emphasis on design and collaboration.

- **London School (Mockist TDD):**
    - **Strengths:**
        - Encourages better design and separation of concerns.
        - Ideal for systems with complex dependencies.
        - Facilitates collaboration between developers.
        - **Critical point:** Smaller tickets require trust in co-workers' code quality. The London approach inherently produces "just better" code, enabling faster reviews and fewer bottlenecks.
    - **Weaknesses:**
        - Over-mocking and brittle tests.
        - Requires a deeper understanding of design patterns.

- **Compare and contrast:**
    - Real-world analogy: Building a car vs. assembling a team to build a car.
    - Choice depends on the problem domain and team dynamics.

- **Additional insights:**
    - Refactoring tests to replace mocks with real implementations (as suggested in [this article](https://blog.devgenius.io/detroit-and-london-schools-of-test-driven-development-3d2f8dca71e5)) can improve test robustness.
    - **Meme idea:** "Banks hate him for this one trick!" (e.g., using adapters or breadth-first development).

- **Transition:**
    - "Now, let’s dive into how one of these approaches can revolutionize your workflow in C#."

---

## Section 3: Deep Dive into Leveraging TDD in C# (10 minutes)

- **Choose one approach (e.g., London School):**
    - Why it’s effective in C# for certain scenarios.

- **Concrete example:**
    - Example: Building a feature in an ASP.NET Core application.
    - Break down a large ticket into smaller, testable units.
    - Demonstrate writing tests first, mocking dependencies, and refactoring.

- **Best practices:**
    - **Test runner:** Use a continuous test runner with near-instant test execution.
    - **Triangulation:** As discussed in *Test Driven Development by Example*, use multiple test cases to drive generalization.
    - **Isolation:** Aim for tests to run in isolation. If sharing an instance is necessary, guard it rigorously as a fixture.
    - **Intent:** Make your intent known—name variables like `expected` and `actual`. For derived values (e.g., percentages), calculate them within the test instead of hardcoding.
    - **Stutter tests:** Start with tests that do nothing (e.g., divide by zero) to validate the simplest case.
    - **Testing unknown APIs/SDKs:** Writing tests against an unknown API is the fastest way to understand its behavior.
    - **Edge cases:** Don’t manually verify—write a test instead.
    - **Regression tests:** When a failure occurs, write a test to prove it before fixing. In a well-tested codebase, a regression is a sign to reassess the surrounding code.

- **Benefits:**
    - Faster feedback loops.
    - Improved code quality and maintainability.
    - Ability to parallelize work on smaller tickets.

- **Common pitfalls:**
    - Over-mocking or overly complex tests.
    - Tips for avoiding these pitfalls.

- **Call to action:**
    - "Try this approach in your next project!"

---

## Round-Up and Closing Statements (5 minutes)

- **Recap the main points:**
    - Two schools of TDD and their strengths/weaknesses.
    - Leveraging one approach in C# for better efficiency.

- **Reinforce the value of TDD:**
    - Saves time, improves code quality, and transforms workflows.

- **Team consistency:**
    - While TDD is powerful, team consistency in coding practices takes priority.
    - Share what you’ve learned and consider trying TDD on a splinter project. A unified team is better than a fractured one.

- **Motivational note:**
    - "TDD isn’t just about writing tests—it’s about writing better software and becoming a better developer."

- **Call to action:**
    - Share experiences on social media using #TDDMelbourne.
    - Invite questions and further discussion.

---

# Again I ask you

<!--
Let's go back to that theoretical:

In that project speed was touted as mattering above all else, we have been promised that as soon as we get this live we will be given
the time needed to go back around and clean up the implementation.

Hands down if we push back on our teams standard testing standards for the sake of the project
OR
===pause=== remember people, ego is on the line ===pause=== Hands up or slightly raised if we deliver the code with our 
standard and some would argue rather rigorous testing practices?
-->

---

## Thank You!