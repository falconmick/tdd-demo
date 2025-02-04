---
layout: cover
---

# Unlocking Hidden Efficiency

## Seamless Solutions with TDD You Didn't Know You Needed

<!-- 
Test Driven Development has largely being dismissed by large swaths of developers, and in some cases, it's applied 
without a clear understanding of when; and how; to use its varying tools effectively. 
In this session I will go into the origins test-driven development;
my personal approach;
and how you can fully leverage its powers become a better developer. 

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
I am a full stack developer from Perth who spends his most of his days working with dotnet as a glorious virtual data plumber.
I would like to see myself as an overly passionate tech who can’t stop getting excited about tech, 
You can find me under the handle falconmick just about everywhere where I talk mostly about coding and console modding.

Throughout my career; with all the teams I have had the opportunity to work with; I have found the following to always be
true: If you want to deliver high quality software testing your code is; without a doubt; the key deciding factor on
how likely you are to succeed. It is not the quality or quantity of developer that matters, but instead the discipline that the
team takes to ensure they validate their code with tests that can be run with as minimal friction in both speed and 
resilience to change.


TIMING FOR SECTION ONE: 1m10s
-->

---

## Question Time

<!--
Before I start lets do a theoretical:
Upper management is in a flurry, our product Y's top competitor Product X has just had an announcement.
Coming in 6 months time is an all new AI chat-bot integration, a game changing feature that is going to send our company broke;
That is, unless, we cannot match or beat their announced delivery date.

In this project speed matters above all else, we have been promised that as soon as we get this live that
We will be given the time necessary to take this beta implementation back to the workshop and made right.

Because we all know that tech demo's don't ever become forever code the second we hand it over.

So the question for the audience: 
you can leave your hands down if we push back on our normal testing requirements; and for the sake of the project 
just get it done
OR
Hands up if we deliver the project with our standard; and some would argue; rather expansive testing practices?

=== delay for hands ===

By the end of this presentation I hope to have as many hands in the air when I ask this question again for all the
reasons that I have coming up, but it all boils down to this one; important; law of delivering software:

# Slow is Smooth. Smooth is Fast

Fun fact: Audience participation varies greatly from country to country and Australia typically is on the more stone
faced side! You all fell for my trap card, now when we reach the end if all goes well I will look like I have converted 
the entire room!

My ego can't wait



TIMING FOR SECTION TWO: 1m25s

-->

---

## Before we ask what, we ask why?

## Opening Statements (5 minutes)

<!--
Now before I start going over the basics of what test-driven development is I thought it might be best to go over why?
More specifically why did I get sucked into the world of testing in the first place!

Like most of you I started out with a surface level appreciation but at the same time a slight disdain for tests. 
After spending the last day or two on my PR and seeing that my 60% coverage was not acceptable to our automated
code coverage overlord; SonarQube; was the very last thing I wanted to see at 5pm on a Friday.

Nevertheless, I would work late and add some basic tests that would cover all the new code, check in my PR and head
home late for the weekend. It didn't help my morale when I came early that next monday and the first thing I see is a review
for obvious bug I had missed. 
I shouldn't have bothered staying late as my PR is now going to take a hot
minute to fix and by then all the other developers will be busy working on their changes so my code won't get another 
review until well after lunch.

At times like this it can feel like test are there purely to make the Pull Request gates happy and not to make my codebase any better.
Not much good that tests was; when It didn't even end up catching anything important.

I have had my fair share of experiences like this up until one day when I was on a new team and I had the great opportunity to
work with a seasoned veteran of the London School of Test Driven development. Having
spent the majority of his career working on software for the stock exchange in england he was in and around all of the 
thought leaders of the London School of Test driven development; as those ideas were first maturing.

There were three main tools he handed over to me that completely changed how I would approach writing code moving forward.
Those three tools were:

Red, Green, Refactor, which is the practice of never writing a single line of production code that doesn't first have
a failing test.

Mocking, which turned into the most valuable tool in how I designed my code moving forward

and finally Adapters, the practice of taking third party code that doesn't line up with your teams coding patterns and
making a small translation layer.

With these three tools I was also handed the task of writing a fairly mundane console app that would use third party
API's to explore a series of file systems, parse the data in it's legacy format, re-arrange the structure including 
sorting into a new storage approach and then persisting. Basically a data migration project with a few bells and whistles.

It was this project that I was first able to see the true power of Test Driven Development. Using mocking I discovered
how the source code wanted to be layed out naturally through outside-in design. When I came across an impossible to
mock third party API? Easy use an adapter to expose a more manageable interface.

Finally the most powerful tool and how every line of code was written:

RED
I would write a small test that I knew would fail

Green
I implement the fix with as little effort as possible but importantly made the failing test pass, then finally

Refactor
Now that my new feature has proven that the test will fail without it, but will succeed with it
I can take a short second to re-arrange and tidy up any mess left over by the previous two steps.

I took a small sample of our data and flawlessly executed this validation migration. I then took
my backup of prod (still not quite believing the results), ran the tool and had a perfect migration. No setting
any breakpoints to debug a silly weird edge case, no last minute re-structuring after finding that the code just wasn't
quite readable.

It just worked. Perfectly. No effort. Only results.

It was at that moment that I found out what all coding could look like;
Welcome to the London School of Test-Driven Development.



TIMING FOR SECTION THREE: 4m 15s


-->

---

# Schools?

<!-- 
Before we go any further, what is all this school nonsense? Well the schools line up with the locations in which
the approaches were first formalised.
-->

---

# Detroit

<!--
the Detroit location came out of the C3 project, the Chrysler Comprehensive Compensation Project to be more precise, 
a payroll re-write being taken on by a team including notably Kent Beck in which he founded extreme programming and went on to develop 
both the books Extreme Programming Explained and Test-Driven Development by Example, of which that last book is coined
as the origin of Detroit School.
-->

---

# London

<!--
Following the explosion of interest in Extreme Programming many community groups were formed around learning and implementing
these ideas, one such group was the London based Extreme Tuesday Club. This group helped Steve Freeman
and Nat Pryce form more techniques and approaches which eventually resulted in the other most well known testing bible,
"Growing Object-Oriented Software, Guided by Tests". This book expanded upon Detroit School; but was more focused around
testing a singular unit with mocks, whereas Detroit was all about testing the combined interactions of our classes as a singular
unit.



TIMING FOR SECTION FOUR: 1m 15s
-->

---

# Why should I use the Detroit School?

<!--
Why would I pick the detroit school? Detroit just makes sense; if up until now you had been writing a few tests
here and there around the important stuff; or to make the metrics look good you almost certainly have been writing
test in a Detroit style. You were likely missing the red green part, but over all you made a point to take obvious
chunks of functionality out of your codebase and made sure that they ended up working as you expected, maybe say for
example you had some logic that would take an existing item, merge some new state into it and then persisted it back
to the database. There is a very good chance that this functionality would be wrapped in a set of nice test that
mocked the database out with an in-memory fake which you then asserted against in the final steps of your test methods.

If this is your codebase now, then great you can transition into the detroit school with ease, just make sure to follow
red green refactor and you're basically there! As soon as you start making this commitment to testing all the features
your adding, as you add them, you will find that refactoring can be done with much greater speed and confidence as if
a feature is important, you will have test around it. Then if you break that feature later on when applying a fix, those 
test you wrote 6 months ago will be there to catch you before releasing broken functionality to your users.

Another great use case for Detroit is code that takes in a series of inputs, transforms the data, applies complicated logic,
then returns a result all without any side-effects from calling out to an external API. When you run into very self-contained
coding exercises like this it can be a great opportunity to take full advantage of some more advanced testing techniques
as such as triangulation and fake it's
-->

---

# Why wouldn't I use the Detroit School?

---

# Test-Splosions

<!--
One reason why you might not want to use this style of testing is the dreaded 1 line change that breaks multiple test suites.
When our unit under test combines multiple shared snippets of code there is a large chance that eventually you will be
writing a new feature or fixing a bug and out of nowhere all your tests start failing. When this happens, especially if
you accidentally forgot to keep your red green refactor itterations small; or worse yet; you were not doing so the pure
stress of having an entire set of test suites start failing can make it hard to find the code change that was at fault.

There are workarounds for this issue, most importantly you can focus on making sure your entire set of suites run continuously
so that any regressions are found at the same time as when changes are being made in the file that is responsible for the
bug is still open and you can just control zed on that thang until you find the responsible line of code. But this also 
just comes with the territory of testing collections of code in multiple locations and just is the price you pay for 
simpler to write tests. Alternatively this type of hardship can be nearly eliminated by London school as you NEVER should
be re-testing shared functionality between suites and the only thing that can break MoneyService's unit tests is a change
that was made inside MoneyService.
-->
---

# Short term speed loss

<!--
Some would argue that another reason to avoid the Detroit school and some would argue test driven development all together
is the short term speed loss. This reasoning is only really true in very small scale changes to existing codebases that
don't want to co-operate with tests. There is a very large chance that in the long run taking the time to pay for the
test now will save a lot of hear-ache in the future, but on occasion it's just not worth it. It's important to note here
that if you are trying to stick to test driven development that the Detroit school is by far the quicker approach to take
over London. === todo: maybe change that last bit ===

=== TODO: probably remove/rewrite this bit ===
in the scenario in which you are trying to improve an existing codebase; If we compare this to London, the large up-front cost of fixing up your
codebase and the un-realistic and very un-impactful job of re-writing the existing test to do so in isolation to the 
classes they were made for realistically would just never happen and you would be stuck with large chunks of legacy
code that is tested in one way (through a more Detroit style) and the newer parts which were extracted and most likely 
don't play all to nice with the other code in our codebase.

It's for this reason that quite often if your jumping into an existing codebase Detroit can just be the only logical
approach.


-->

---

# Why should I use the London School?

<!--
London school is bar far, so much harder to sell without first experiencing it, I can only say that it's worth taking
the time to make a point to just try it out and see where the code takes you.

That is actually one of it's largest draws, especially when compared to Detroit, when you write London there is no
thinking out ahead of time of logical bundles of classes to combine into a scenario to form your tests around.

Instead you grab a feature, you start at the very outside of your code, for example the API endpoint, and you
just assert what needs to happen for this class to be completed. You don't need to implement every single
requirement to get to a complete test, instead you simply write a test that asserts the inputs to your API are 
are passed to your validator,
this then produces a failing test, so we 
define the interface for your validation, 
mock this interface, 
add the call inside your API to call this non-existant validator 
and bam, you have a working test that proves the correct values were provided to the correct
dependencies. This process repeats over and over, without any of the dependencies having a single line of code 
implemented inside of them.

This to most sane developers will sound outlandish, spending multiple coding iterations writing tests that prove
obvious thing X was passed to other obvious thing Y, what exactly am I gaining??

Well what you are gaining is software that is designed with a outside in style. I have found that if I work my way from 
the outside of my code all the way in that I am able to discover shared responsibilities much sooner and can invest in 
designing much more understandable API's as I develop rather than coming back and re-working them later.

Because we always mock every single call, and we never depend upon code external to our unit, we also leave our entire
codebase open to substitution at any time. The best example of this is when you later on in the project run into
a bad race condition bug that is due to fractions of a second differences in calls to a DateTime Now function. If 
we had of been testing without mocks all of our time sensitive code that is causing us headaches will be un-mockable and
near impossible to re-create as a test. When everything is injected anything can be mocked.

I would say the final and possibly most impactful tool that the London School gives you is that it makes splitting up
your features into smaller tickets a much more manageable process. I have found that most teams that I work with who
don't use the London approach will typically find themselves having a single developer delivering an entire feature
from start to end even if the ticket is split up into multiple steps. If a team does split the ticket up into say
one developer working on mapping the user input into a domain model and a second developer
that will persist our data CarInfo data into our SQL database, we sometimes will run into the unfortunate situation
in which both developers implement their own version of the same file. For example the mapping ticket implements
the CarInfo model as a record, which is basically a class that makes working with imutability really easy and
convenient through C# language features as such as the with statements for updating fields. But then we have
the SQL persistence ticket developer also implement CarInfo, but because they're using Entity Framework, a library
that uses class mutation to track field updates to generate SQL queries their class is a plain old boring class
that expects it can be mutated.

One of them now needs to update their codebase, neither of them are happy. 
This is why quite often when a team writes up their tickets they can very often turn the feature ticket
into the entire ticket and not split up it into the individual steps required to complete the feature. If instead of
6 small tickets we had a single big ticket, one developer can grab it and see it from start to end without conflicts.

This all could have been avoided if the priority was to deliver the domain models and interfaces at an earlier stage.
So sometimes this will happen, a feature will have an initial ticket that defines the API endpoint and also sets up
the basic interfaces as such as the validator, mapper, database layer and finally the response mapper. However because
they write test where entire chunks of a feature are the unit they will not be able to write any tests for this code as
we are yet to implement any of them. Through doing this we have gained a shared understanding on how we will integrate
however we also made our code untestable and thus it won't be tested. 

Instead of not testing this important upper layer what if we just for now mocked away all of the mappers, validators and
persistence calls? Well now if later down the line we find a bug in this layer of the codebase we know for a fact
that we will be able to easily re-create the bug as a test and then fix it and validate the fix is good through the
green test pass. As you probably can tell, that was London School approach and just shows that the London school makes
splitting up your tickets into smaller tickets to be much more reliable and approachable.

If your team is finding that their tickets are taking more
than a day to complete this is a good sign that you most likely need to split up your tickets into smaller more
bite sized tickets that take at most half a day to complete, it is at that point that you also might find that
swapping to the London approach will make all of that much manageable.
-->
---

# Why wouldn't I use the London School?

<!--
Maintenance is by in far the largest reason why Detroit might be a better pick for you and your team over London.
When you write 40 tests for a single class and a bunch of em are basic plumbing tests that don't really test much 
you will find that a simple change that refactors a clump of code from one class into another can be excruciating to
move.

To do so correctly you would have to basically fully re-create the entire red green refactor for the entirety of the
code being moved plus setup new tests in the old class to validate the refactored chunk of code's interface is being 
correctly called.

When your simply trying to just clean up this can be burdensome and might lead to less time spent refactoring.
There is a silver lining here in that it can help if your suffering from premature re-fac-tile dysfunctions but realistically
making it this hard to get work done can be a problem.

With that said I have found that with a small amount of bending of the rules one can cut paste refactor the unit test
such that the original tests magically move across without going through proper red-green-refactor. One other solution
would be to once a unit test is complete to take the time to go back over the suite and remove the scaffolding test such
that all that remains are tests that are validating the extremities of the test like that we return success once the
API returns OR the tests that shows we return a validation error. This is the by the book approach to managing this 
complexity, I just have always had a hard time getting rid of my babies and just tend to keep them all.
-->
---

# Which one should I be following?

<!--
It can sometimes be hard to know what is the correct approach to take when writing tests for your codebase.
Do I take the detroit approach which more closely matches up with how developers instinctively test

OR

do I take a much more extreme route and allow my tests to define my API, choosing to chip away at the code one
concern at a time through the isolation that mocking allows.

The answer to this is everybody's favourite; it depends; however this time we get to complete that sentence by saying
it depends on you team.

One of the biggest mistake any new developer, no matter the seniority, can make when joining a new team is to try and 
uproot an established team coding approach and replace it with their own.

Does that mean if you join a team and they have no real testing strategy, just a few tests here and there that
that you cannot come in and improve things?

No it does not, what it means is you have a team who is open to the idea of testing, they just need a little help.
What that also means is more involved practices like the London school are more than likely; a no-go, as chances are there are
landmines straggling all throughout the codebase that will refuse to be isolated with mocking, so you likely want to 
minimise your mocking and focus less on writing unit tests and more on integration-ish tests.

It is important to talk with your colleagues, get their feedback on how code is being written and also to provide some
ideas too on how things could be improved to see how that works for the team. Most developers know deep down they 
should be writing tests but just struggle to justify their time doing so. If you come in help make testing the norm
you will likely find they come with you willing and happy.

What this all mostly boils down to is there is a high chance you should just use Detroit even if deep down you really 
wish you could be writing London which has been my reality for most of my recent engagements. If a new project is coming
up and your confident with the London approach, why not start out with heavy mocking and see how it works for your team
you can always pivot to detroit if it's not working out. By that point hopefully even if you do have to remove the London
style your codebase will already have a bunch of clarity from the outside-in work done so far.
-->
---

# Going deeper

<!--
Now that we know about the different approaches to test driven development I think it would be no better time than
ever to go back to the key techniques that we must apply to our coding and give some better explanations and examples
of what it looks like to properly implement them. Startin with Red Green Refactor.
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
factory provided by the third party and then executes it all under the much simpler and relevant to our codebase 
getter pattern.

It is only important that this layer remain as simplistic as possible as it can often not be viable to test it 
without integration testing, so if your adapter grows too far you will end up having dangerously uncovered code.

In the case of the code that was being developed for the company I was working for at the time, the use of adapters
was alot more extreme than you might have expect, we even adapted out DateTime, which gave our tests the ability to act as
Pure functions which allowed us to have much less brittle testing and also made testing edge cases a cakewalk as we had
full control over how much the time changes between each call to Now. When I go over a detailed example of how I think
TDD should be implemented in my C# example I will dig into this further.

-->

---

# Example Time

<!--
For this example I will use C# as this is my bread and butter, so I can give hopefully the most concrete example of what
Test Driven Development can look like. I will be taking all the three key concepts from above and combining
them together to create a record inside CosmosDB.
-->

---

# Demo

````md magic-move
```cs
public class UpdateCarInfoCommandHandler_Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
```

```cs
public class UpdateCarInfoCommandHandler_Tests
{
    private IUpdateCarInfoCommandHandler _handler;

    [SetUp]
    public void Setup()
    {
        _handler = new UpdateCarInfoCommandHandler();
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
```
````

<!--
v1 starting point
v2 - red - UpdateCarInfoCommandHandler not defined
-->

---

<!--
For this example I will use C# as this is my bread and butter, so I can give hopefully the most concrete example of what
Test Driven Development can look like. I will be taking all the three key concepts from above and combining
them together to create a record inside CosmosDB.
-->

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
        - **Critical point:** Smaller tickets require trust in co-workers' code quality. The London approach inherently
          produces "just better" code, enabling faster reviews and fewer bottlenecks.
    - **Weaknesses:**
        - Over-mocking and brittle tests.
        - Requires a deeper understanding of design patterns.

- **Compare and contrast:**
    - Real-world analogy: Building a car vs. assembling a team to build a car.
    - Choice depends on the problem domain and team dynamics.

- **Additional insights:**
    - Refactoring tests to replace mocks with real implementations (as suggested
      in [this article](https://blog.devgenius.io/detroit-and-london-schools-of-test-driven-development-3d2f8dca71e5))
      can improve test robustness.
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
    - **Triangulation:** As discussed in *Test Driven Development by Example*, use multiple test cases to drive
      generalization.
    - **Isolation:** Aim for tests to run in isolation. If sharing an instance is necessary, guard it rigorously as a
      fixture.
    - **Intent:** Make your intent known—name variables like `expected` and `actual`. For derived values (e.g.,
      percentages), calculate them within the test instead of hardcoding.
    - **Stutter tests:** Start with tests that do nothing (e.g., divide by zero) to validate the simplest case.
    - **Testing unknown APIs/SDKs:** Writing tests against an unknown API is the fastest way to understand its behavior.
    - **Edge cases:** Don’t manually verify—write a test instead.
    - **Regression tests:** When a failure occurs, write a test to prove it before fixing. In a well-tested codebase, a
      regression is a sign to reassess the surrounding code.

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
    - Share what you’ve learned and consider trying TDD on a splinter project. A unified team is better than a fractured
      one.

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