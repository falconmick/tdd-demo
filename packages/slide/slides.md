---
theme: the-unnamed-custom
layout: cover
background: /sponsor.png
dimBackground: false
---

<!--
First and foremost! Thank you to all the sponsors, without them such an open an inclusive event just isn’t possible
-->

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
-->

---
layout: cover
background: /bingo.png
dimBackground: false
---

<!--
Also don’t forget, sponsor bingo… Maybe after my talk though!

Firstly, who am I?
-->

---
layout: about-me

helloMsg: Hello!
name: Michael Crook
imageSrc: /michael.png
position: left
job: Full-stack dotnet Contractor
line1: www.mcrook.com
line2:
social1: bsky.app/profile/mcrook.com
social2: linkedin.com/in/falconmick
social3: github.com/falconmick
---

<!--
Hi
I’m Michael!
I am a full stack developer from Perth who spends his most of his days working with dotnet as a glorious virtual data plumber.
I would like to see myself as an overly passionate tech who can’t stop getting excited about tech, 
You can find me under the handle falconmick just about everywhere where I talk mostly about coding and console modding.
-->

---
layout: about-me

helloMsg: Hello!
name: Michael Crook
imageSrc: /michael.png
position: left
job: Full-stack dotnet Contractor
line1: www.mcrook.com
line2:
social1: bsky.app/profile/mcrook.com
social2: linkedin.com/in/falconmick
social3: github.com/falconmick
---

<!--
Throughout my career; with all the teams I have had the opportunity to work with; I have found the following to always be
true: If you want to deliver high quality software testing your code is; without a doubt; the key deciding factor on
how likely you are to succeed. It is not the quality or quantity of developer that matters, but instead the discipline that the
team takes to ensure they validate their code with tests that can be run with as minimal friction in both speed and 
resilience to change.
-->

---
layout: center
---

# A Tale as old as time

<!--
Now before I start going over the basics of what test-driven development is I thought it might be best to go over why?
More specifically why did I get sucked into the world of testing in the first place!

Like most of you I started out with a surface level appreciation but at the same time a slight disdain for tests. 
After spending the last day or two on my PR and seeing that my 60% coverage was not acceptable to our automated
code coverage overlord; SonarQube; was the very last thing I wanted to see at 5pm on a Friday.

-->

---
layout: center
---

# A Tale as old as time
<h2 v-click style="position: absolute;top: 60%;">PR Failed</h2>

<!--
Nevertheless, I would work late and add some basic tests that would cover all the new code, check in my PR and head
home late for the weekend. It didn't help my morale when I came early that next monday and the first thing I see is a review
for obvious bug I had missed. 

{click}

I shouldn't have bothered staying late as my PR is now going to take a hot
minute to fix and by then all the other developers will be busy working on their changes so my code won't get another 
review until well after lunch.

-->

---
layout: center
---

# A New Hope?

<!--
At times like this it can feel like test are there purely to make the Pull Request gates happy and not to make my codebase any better.
Not much good that tests was; when It didn't even end up catching anything important.

I have had my fair share of experiences like this up until one day when I was on a new team and I had the great opportunity to
work with a seasoned veteran of the London School of Test Driven development. Having
spent the majority of his career working on software for the stock exchange in england he was in and around all of the 
thought leaders of the London School of Test driven development; as those ideas were first maturing.

-->

---

# The Three Testings Tools of Power!

<v-clicks>

- ## Red Green Refactor
- ## Mocking
- ## Adapters
</v-clicks>

<!--
There were three main tools he handed over to me that completely changed how I would approach writing code moving forward.
Those three tools were:

Red, Green, Refactor, which is the practice of never writing a single line of production code that doesn't first have
a failing test.

Mocking, which turned into the most valuable tool in how I designed my code moving forward

and finally Adapters, the practice of taking third party code that doesn't line up with your teams coding patterns and
making a small translation layer.

-->

---

# My First TDD Project

<v-clicks>

- ## Console App to migrate data from legacy to new
- ## Discovered outside in software design
- ## Uncovered the most powerful tool of all...

</v-clicks>

<!--
With these three tools I was also handed the task of writing a fairly mundane console app that would use third party
API's to explore a series of file systems, parse the data in it's legacy format, re-arrange the structure including 
sorting into a new storage approach and then persisting. Basically a data migration project with a few bells and whistles.

It was this project that I was first able to see the true power of Test Driven Development. Using mocking I discovered
how the source code wanted to be layed out naturally through outside-in design. When I came across an impossible to
mock third party API? Easy use an adapter to expose a more manageable interface.

Finally the most powerful tool and how every line of code was written:

-->

---
layout: center
class: spaced-h1
---

<style>
.spaced-h1 h1 {
    margin-bottom: 0.2rem !important;
}
</style>

<v-clicks>

# RED
# GREEN
# REFACTOR

</v-clicks>

<!--
{click}
&nbsp;**RED**&nbsp;
I would write a small test that I knew would fail

{click}
&nbsp;**Green**&nbsp;
I implement the fix with as little effort as possible but importantly made the failing test pass, then finally

{click}
&nbsp;**Refactor**&nbsp;
Now that my new feature has proven that the test will fail without it, but will succeed with it
I can take a short second to re-arrange and tidy up any mess left over by the previous two steps.

-->

---

# My First TDD Project

<v-clicks>

- ## Flawless Victory
- ## No Debugging
- ## Beautiful Code

</v-clicks>

<!--
I took a small sample of our data and flawlessly executed this validation migration. 

{click} I then took my backup of prod (still not quite believing the results), ran the tool and had a perfect migration. 

{click} No setting any breakpoints to debug a silly weird edge case, 

{click} no last minute re-structuring after finding that the code just wasn't quite readable.

-->

---
layout: center
---

# All Results; Zero Effort

<!--
It just worked. Perfectly. No effort. Only results.

It was at that moment that I found out what all coding could look like;
Welcome to the London School of Test-Driven Development.
-->

---

# Schools?

<!-- 
Before we go any further, what is all this school nonsense? Well the schools line up with the locations in which
the approaches were first formalised.
-->

---

# Schools?

- ## Detroit

<!--
the Detroit location came out of the C3 project, the Chrysler Comprehensive Compensation Project to be more precise, 
a payroll re-write being taken on by a team including notably Kent Beck in which he founded extreme programming and went on to develop 
both the books Extreme Programming Explained and Test-Driven Development by Example, of which that last book is coined
as the origin of Detroit School.
-->

---

# Schools?

- ## Detroit
- ## London

<!--
Following the explosion of interest in Extreme Programming many community groups were formed around learning and implementing
these ideas, one such group was the London based Extreme Tuesday Club. This group helped Steve Freeman
and Nat Pryce form more techniques and approaches which eventually resulted in the other most well known testing bible,
"Growing Object-Oriented Software, Guided by Tests". This book expanded upon Detroit School; but was more focused around
testing a singular unit with mocks, whereas Detroit was all about testing the combined interactions of our classes as a singular
unit.
-->

---

# Why should I use the Detroit School?

- ## Comes naturally

<!--
Why would I pick the detroit school? Detroit just makes sense; if up until now you had been writing a few tests
here and there around all the important stuff; or at least to make the metrics look good you almost certainly have been writing
in this Detroit style. You were likely missing the red green part, but over all you made a point to take obvious
chunks of functionality out of your codebase and made sure that they ended up working as you expected, 

-->

---

# Why should I use the Detroit School?

- ## Comes naturally
- ## Test as a whole, mock the pain away

<!--
Say for example you had some logic that would take an existing item, merge some new state into it and then persisted it back
to the database. There is a very good chance that this functionality would be wrapped in a set of nice test that
mocked out the database out with an in-memory fake which you then asserted against in the final steps of your test methods.

-->

---

# Why should I use the Detroit School?

- ## Comes naturally
- ## Test as a whole, mock the pain away
- ## You can refactor with confidence

<!--
If this is your codebase now, then great; you can transition into the detroit school with ease, just make sure to follow
red green refactor and you're basically there! As soon as you start making this commitment to testing all the features, 
as you add them, you will find that refactoring can be done with much greater speed and confidence as if
a feature is important, you will have test around it. Then if you break that feature later on when applying a fix, those 
test you wrote 6 months ago will be there to catch you before releasing broken functionality to your users.
-->

---

# Why should I use the Detroit School?

- ## Comes naturally
- ## Test as a whole, mock the pain away
- ## You can refactor with confidence
- ## Works wonders in some situations

<!--
Another time that the Detroit approach can really shine is when writing small self-contained utilities which have no side effects and 
simply take incoming arguments and transform them into an output based off a series of known rules. Because of this
code kata's as such as supermarket pricing examples or others can be a good way to practice Test driven development in
the Detroit style. 

-->

---

# Why should I use the Detroit School?

- ## Comes naturally
- ## Test as a whole, mock the pain away
- ## You can refactor with confidence
- ## Works wonders in some situations
- ## Pushes you to isolate complexity

<!--
From there you will find it easier to spot good sections of your codebase to treat as a unit for your
testing. This will help guide your coding in such a way to push any required side effects to the edges of your codebases such
that they are much easier to mock. This is showing us that testing not only can add reliability but also encourage us to
write our code in such ways to isolate complexity.
-->

---

# Why wouldn't I use the Detroit School?

- ## Test-Splosions

<!--
One reason why you might not want to use this style of testing is the dreaded 1 line change that breaks multiple test suites.
When our unit under test combines multiple shared snippets of code there is a large chance that eventually you will be
writing a new feature or fixing a bug and out of nowhere all your tests start failing. When this happens, especially if
you accidentally forgot to keep your red green refactor iterations small; or worse yet; you were not doing so; the instant
stress of having an entire set of test suites start failing can make it hard to find the code change that was at fault.

-->

---

# Why wouldn't I use the Detroit School?

- ## Test-Splosions

<!--
There are workarounds for this issue, most importantly you can focus on making sure your entire set of suites run continuously
so that any regressions are found at the same time as when changes are being made 
and you can just control zed on that thang until you find the responsible line of code. But this also 
just comes with the territory of testing collections of code in multiple locations and just is the price you pay for 
simpler to write tests. Alternatively this type of hardship can be nearly eliminated by London school as you NEVER should
be re-testing shared functionality between classes and the only thing that can break a test for a given suite is code
that exists in that very class as the unit of each test is at a class level
-->
---


# Why wouldn't I use the Detroit School?

- ## Test-Splosions
- ## Short term speed loss

<!--
Some would argue that another reason to avoid the Detroit school or test driven development all together
is the short term speed loss. 
This reasoning is only really true in very small scale changes to existing codebases that
don't want to co-operate with tests. There is a very large chance that in the long run taking the time to pay for the
test now; will save a lot of hear-ache in the future, but on occasion it's just not worth it. 

It's important to note here that if you are trying to migrate to test driven development 
that the Detroit school is by far the quicker approach to take
over London.

It's for this reason that quite often if your jumping into an existing codebase Detroit might be the only logical approach.
-->

---

# Why should I use the London School?

<v-clicks>

- ## BIAS ALERT!!!
- ## Once you know... you know

</v-clicks>

<!--
Bias warning, I love the London approach

London school is bar far, so much harder to sell without first experiencing it, I can only say that it's worth taking
the time to make a point to just try it out and see where the code takes you.

That is actually one of it's largest draws, especially when compared to Detroit, when you write London there less
thinking out ahead of time what classes will be required to form your tests around.

-->

---

# Why should I use the London School?

- ## BIAS ALERT!!!
- ## Once you know... you know
- ## Tests come fast and without dependencies

<!--
Instead you naturally start at the origin of your feature, such as the API endpoint, and you use your tests to define
the structure of your class. If the first step of accepting an incoming request is to validate the input to make sure
it is valid, then you write a test that asserts this. It doesn't matter that the validator interface doesn't exist, 
you can go and define it. Once you have your interface that will be able to accept the input and return a suitable
output, you skip the implementation step of the validator and instead define a mock for your new interface and
utilise the assertion tools provided by the mock to ensure that the validator is called and then later in another
test once you implement the call you can then stub out the functionality, allowing for easy testing setup
to validate each unique and potentially hard to reproduce branch in your class.

--> 

---

# Why should I use the London School?

- ## BIAS ALERT!!!
- ## Once you know... you know
- ## Tests come fast and without dependencies
- ## Outside In code flow

<!--
This process repeats over and over, without any of the other downstream classes needing to be implemented, we instead
focus purely on the branches and edge cases tracked by this class.

This to most sane developers will sound outlandish, spending multiple coding iterations writing tests that prove
obvious thing X was passed to other obvious thing Y, what exactly am I gaining??

Well what you are gaining is software that is designed with an outside in style. I have found that if I work my way from 
the outside of my code all the way in that I am able to discover shared responsibilities much sooner and can invest in 
designing much more understandable API's as I develop rather than coming back and re-working them later.

-->

---

# Why should I use the London School?

- ## BIAS ALERT!!!
- ## Once you know... you know
- ## Tests come fast and without dependencies
- ## Outside In code flow
- ## Everything is testable

<!--
Because we always mock every single call, and we never depend upon code external to our unit, we also leave our entire
codebase open to substitution at any time. The best example of this is when you later on in the project run into
a bad race condition bug that is due to fractions of a second differences in calls to a DateTime Now function. If 
we had of been testing without mocks all of our time sensitive code that is causing us headaches will be un-mockable and
near impossible to re-create as a test. When using London everything is injected anything can be mocked. This is why you will
even end up mocking DateTime functionality. 

-->

---
layout: center
---

# London's Calling

<!--
I would say the final and possibly most impactful tool that the London School gives you is that it makes splitting up
your features into smaller tickets a much more manageable process. I have found that most teams that I work with who
don't use the London approach will typically find themselves having a single developer delivering an entire feature
from start to end even if the ticket is split up into multiple steps. 

-->

---
layout: two-cols
dragPos:
  harry: 115,398,161,161
  kiara: 661,395,161,161
  "'foo'": 394,290,40,40
  "'circleTwo'": 825,284,40,40
  "'bar'": 697,431,89,74
  "'crossTwo'": 145,441,96,79
---

# Harry

````md magic-move
```cs
public interface ICarInfoMapper
{
    ??? Map(CarInfoInput input);
}
```
```cs
public interface ICarInfoMapper
{
    CarInfo Map(CarInfoInput input);
}

public record CarInfo
{
    public string? CarName { get; init; }
}
```
````



<img v-drag="'harry'" src="/harry.png" />

::right::

# Kiara

````md magic-move
```cs
public interface ICarInfoRepository
{
    Task Update(??? input);
}
```
```cs
public interface ICarInfoRepository
{
    Task Update(CarInfo input);
}

public class CarInfo
{
    public string? CarName { get; set; }
}
```
````

<img v-drag="'kiara'" src="/kiara.png" />


<v-drag pos="'foo'" v-mark="{ at: 3, color: '#934', type: 'circle' }"></v-drag>
<v-drag pos="'circleTwo'" v-mark="{ at: 3, color: '#934', type: 'circle' }"></v-drag>
<v-drag pos="'bar'" v-mark="{ at: 4, color: '#934', strokeWidth: 30, type: 'crossed-off' }"></v-drag>
<v-drag pos="'crossTwo'" v-mark="{ at: 4, color: '#934', strokeWidth: 30, type: 'crossed-off' }"></v-drag>

<!--
If a team does split the ticket up into say
**Harry** working on mapping the user input into a domain model and **Kiara**
that will persist our data into our SQL database, we sometimes will run into the unfortunate situation
in which both developers implement their own version of the same file. For example the mapping ticket implements
the CarInfo model as a record, 

{click} and the SQL persistence ticket developer also implement CarInfo, 
but because they're using Entity Framework, 

{click} a library that uses class mutation to track field updates to generate SQL 
queries their class is a plain old boring class that expects it can be mutated.

{click} One of them now needs to update their codebase, neither of them are happy. 

{click}This is why quite often when a team writes up their tickets they can very often turn the feature ticket
into the entire ticket and not split up it into the individual steps required to complete the feature. If instead of
6 small tickets we had a single big ticket, one developer can grab it and see it from start to end without conflicts.

-->

---
layout: center
---

# London's Calling 

<!--
TODO:::::::::::::::::::::
This all could have been avoided if the priority was to deliver the domain models and interfaces at an earlier stage.
So sometimes this will happen, a feature will have an initial ticket that defines the API endpoint and also sets up
the basic interfaces as such as the validator, mappers and database layer. However because
they write test in the detroit style they will not be able to write any tests for this code as
we are yet to implement any of these interfaces. Now we are going to check in a lot of code with 0 code coverage
as we cannot write any tests for this code yet as it is not implemented. This can often lead to code that doesn't
play nice with testing later on as the hardest code to write tests for is that code which already exists.

--

Instead of not testing this important upper layer what if we just for now mocked away all the mappers, validators and
persistence calls? Well now if later down the line we find a bug in this layer of the codebase we know for a fact
that we will be able to easily re-create the bug as a test and then fix it and validate the fix is good through that 
test passing. The London approach forces us to at all times write code that has a failing test and it also makes each
line we write more testable.

todo: make sure its clear that by london we gain the ability to add the initial bits of code
for all to integrate against WHICH was made with tests

--

If your team is finding that their tickets are taking more
than a day to complete this is a good sign that you most likely need to split up your tickets into smaller more
bite sized tickets; that take at most half a day to complete, it is at that point that you also might find that
swapping to the London approach will make all of that much manageable.

TIMING FOR SECTION EIGHT: 5min 50sec
-->

---

# Why wouldn't I use the London School?

<!--
Maintenance is by in far the largest reason why Detroit might be a better pick for you and your team over London.
When you write 40 tests for a single class and a bunch of em are basic scaffolding tests that don't really test much 
you will find that a simple change that refactors a clump of code from one class into another can be excruciating to
move.

To do so correctly you would have to basically fully re-create the entire red green refactor for the entirety of the
code being moved plus setup new tests in the old class to validate the refactored chunk of code's interface is being 
correctly called.

When your simply trying to just clean up this can be burdensome and might lead to less time spent refactoring.
There is a silver lining here in that it can help if your suffering from premature re-fac-tile dysfunctions but realistically
making it this hard to get work done can be a problem.

With that said I have found that with a small amount of bending of the rules one can cut paste refactor the unit test themselves
such that the original tests magically move across without going through proper red-green-refactor process. One other solution
would be to once a unit test is complete to take the time to go back over the suite and remove the scaffolding test such
that all that remains are tests that are validating the extremities of the unit like that we return success once the
API returns OR the unit tests that shows we return a validation error. This is the by the book approach to managing this 
complexity, I just have always had a hard time getting rid of my tests and just want to keep all my babies.

TIMING FOR SECTION NINE: 1m 35s


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
landmines straggled all throughout the codebase that will likely refuse to be isolated with mocking, so you will want to 
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

TIMING FOR SECTION TEN: 2m 25s
-->
---

# Going deeper

<!--
Now that we know about the different approaches to test driven development, now could be no better time than
ever to go back to the techniques that we can apply to our coding and give some better explanations and examples
of what it looks like to properly implement them. Starting with a Red Green Refactor example using javascript
-->

---

# RED

# GREEN

# REFACTOR

<!--

RED
GREEN
REFACTOR

It doesn't matter what kinda of approach you take to test driven development, this one thing will remain consistent among them
all. 
-->

---

# RED

````md magic-move
```js {*|2}
it('Should sum 2 plus 2 to equal 4', () => {
    const result = sum(2, 2)
    
    expect(result).toBe(4)
});
```
````

<!--

First we write a test that will fail, it should be small and easy to write. 

{click}

It doesn't even have to compile, red can refer both to the test status bar or the syntax error caused by
the non-existent sum function your test is referring to.
-->

---

# GREEN

````md magic-move
```js {2|*}
it('Should sum 2 plus 2 to equal 4', () => {
    const result = sum(2, 2)
    
    expect(result).toBe(4)
});
```

```js
it('Should sum 2 plus 2 to equal 4', () => {
    const result = sum(2, 2)
    
    expect(result).toBe(4)
});

const sum = (augend, addend) => 4
```
````

<!--
{click}

Now we need to make that test work with the minimal amount of changes as possible
all sins permitted, was your test that two plus two equals four? Great stub out the method with
the two arguments of the augend and the addend and return four. 

{click}

It does not matter that our implementation is obviously wrong, that is 100% ok!
If you can look at an implementation and see that it is flawed that is a sign that you do not have
enough tests yet, and you need to continue the red green refactor cycle until you come to a more concrete output.
This approach is known as stutter testing and can often be used in conjugation with triangulation approaches.
-->

---

# REFACTOR

````md magic-move
```js
it('Should sum 2 plus 2 to equal 4', () => {
    const result = sum(2, 2)
    
    expect(result).toBe(4)
});

const sum = (augend, addend) => 4
```

```js
it('Should sum 2 plus 2 to equal 4', () => {
    const result = sum(2, 2)
    
    expect(result).toBe(4)
});

const sum = (augend, addend) => augend + addend;
```
````

<!--
Refactor is a key part of the "design" aspect of test driven design. If you have been following TDD correctly
your solution will be as minimalistic as possible. Does the world's most understandable and maintainable code
come into existence for free? Normally not, so the refactor stage is to make code that you feel comfortable checking
that code in.

{click}

In this specific instance our refactoring is required to remove duplication between our test which defines 4 as the
expected result and our implementation which just parrots it back to us. This is a really minimalistic example which
is why this might feel a bit silly, but the point of this example is that even if a solution feels wrong, if it
satisfies the test it is correct. It is the point of the refactor step to remove duplication and tidy up

In more realistic scenarios quite often the act of adding on additional tests will flush out the silly solutions
we come up with to satisfy the first few tests we write.

Your **test code** is just as important as your **production code**. If there's **duplication** in your tests that could 
be solved with **refactoring**, the best time to fix it is when your **codebase is green**. Apply these fixes with the 
same **rigor** as you would in your **production code**.


TIMING FOR SECTION ELEVEN: 2m 40s
-->

---

# Mocking

<!--
Another tool that is invaluable is mocking, in particular extensive mocking.

Mocking sounds like a simple subject; but depending on how you approach it you can get vastly different results.

One such approach is creating a new concrete implementation of an interface that is injected into your codebase that
was designed purely for testing say for example a mock implementation of your databases. This implementation won't always
be fully extensive but will allow us to simulate calling out to the real database Without any of the drawbacks
of using a real database during testing. Through creating the mock by hand we also have the ability to embed test utilities as 
such as data initialization or what ever other test utility we can put our minds to. 

This is a common approach when using the Detroit School, by making a concrete implementation we can allow a series of
interactions to add up together. we might for example have a test that first finds a value
in the database and then modifies it. If we hadn't of mocked this the next run of the test might have not worked now 
that the data is now modified OR if we had used a substitution framework instead of our handcrafted mock we
would have to write a fair bit of unique setup code.

Speaking of substitution frameworks; in C# we have Moq, fake it easy or nsubstitute just to name a few.
These tools allow for expression to be written which get called in place of the interface we supply them,
allowing us to define inline to our test what that call will return OR even allow us to assert that the call was made at all.

The only thing to keep in mind here is even though these frameworks do have some support for classes, they are limited
and a lot of the time a mock around a class will fail. It is for this reason that when using lots of mocking you tend
to also need to be stricter with the separation of logic to data and also the usage of adapters on third party code.


TIMING FOR SECTION TWELVE: 2 min


-->

---

# Adapters

<!--
The adapter pattern is not too strict of an idea, in that third party code instead of being directly relied upon, is 
instead abstracted away by an adapter layer, which can and often will help remove implementation details from our
dependant codebase, say for example our adapter might provide a getter for the third party that both sets up a
factory provided and then executes it all under the much simpler and relevant to our codebase pattern.

It is only important that this layer remain as simplistic as possible as it can often not be viable to test it 
without integration testing, so if your adapter grows too much you will end up having dangerously uncovered section of code.

When following the London approach of test driven development the use of adapters
will be a lot more extreme than you might expect, I even adapted out DateTime, which gives our tests the ability to act as
Pure functions which leads to less brittle testing and also makes testing edge cases a cakewalk as we have
full control over how much the time changes between each call to Now. When I go over a detailed example of how I think
TDD should be implemented in my C# example I will dig into adapters further.


TIMING FOR SECTION THIRTEEN: 1m 10s

-->

---

# Example Time

<!--
For this example I will use C# as this is my bread and butter, With this I will be able to give a concrete example of
how Test Driven Development can be implemented. I will be taking all the three key concepts from above and combining
them together to validate a record passed in and depending on if the model is valid, returning back out a result
that signifies this, otherwise we log an error if it is not valid.

To make this demo possible I am using the following tools:

- NUnit, my test runner and assertion library
- and FakeItEasy, a mocking library that allows for inline definitions of mocks and also exposes several
useful tools to validate how our mocks have been interacted with

Originally this was going to be live, but then I opened up my mac laptop and remembered all my bindings are windows
based and I am 100% completely lost... So in the interest of not flapping around like a grounded fish for the next 10
min, I will instead jump to my backup slides for this demo.


TIMING FOR SECTION 14: 50s
-->

---

# Demo

<!--
FALL BACK TO WALKTHROUGH IF IN DOUBT, blame time left (probably true)

- v1 - starting point
- v2 - red - ValidateCarInfoCommandHandler not defined
- v3 - green - implemented missing methods, test now passes
- v4 - red - add Handler method, it doesnt exist
- v5 - green - implement handle method
- v6 - refactor - give the test a name that makes sense
- v7 - red - update HandleAsync return CarInfoUpdateResult + validate result not null
- v8 - green - updated return type
- v9 - red - update default result success to false
- v10 - green - update success in CarInfoUpdateResult true in implementation
- v11 - refactor - extract good info fake into method
- v12 - refactor remove redundant test
- v13 - red - add validate test failing build as Validator interface does not exist
- v14 - red - implement validator interface
- v15 - green - call validate
- v16 - red - Create negative test scenario that returns false (we always return true atm)
- v17 - red - return validate as result, breaking a test (as validate not return true unless mock setup)
- v18 - green - setup happy path
- v19 - red - Faker cannot play nice with ILogger.LogError extensions
- v20 - green - extracted basic ILogger adapter and implement
- v21 - refactor to use alternate mock, comment out log to prove the green test still fails if missing implementation
-->

---

# Demo

````md magic-move
```cs
public class ValidateCarInfoCommandHandler_Tests
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

```cs {*|3,8|*}
public class ValidateCarInfoCommandHandler_Tests
{
    private IValidateCarInfoCommandHandler _handler;

    [SetUp]
    public void Setup()
    {
        _handler = new ValidateCarInfoCommandHandler();
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
First we start with our blank unit test, this is our starting point so we need a red

{click}

Now we add in the handler which we will be testing `ValidateCarInfoCommandHandler`

{click}

The red phase of the cycle is in that this class does not exist. A compilation error is as valid of a red steps
as a failing test is.

{click}

Our next step is green, which we will achieve through implementing the Update Car Info Command Handler
with as little effort as possible
-->

---

````md magic-move
```cs
public class ValidateCarInfoCommandHandler : IValidateCarInfoCommandHandler
{
}

public interface IValidateCarInfoCommandHandler
{
}
```
````

<!--
And that's it

Note how all I need do to get into the green is simply define the interface and the implementation so that is all
I have done
-->

---

````md magic-move
```cs
public class ValidateCarInfoCommandHandler_Tests
{
    private IValidateCarInfoCommandHandler _handler;

    [SetUp]
    public void Setup()
    {
        _handler = new ValidateCarInfoCommandHandler();
    }

    [Test]
    public async Task Test1()
    {
        Assert.Pass();
    }
}
```

```cs
public class ValidateCarInfoCommandHandler_Tests
{
    private IValidateCarInfoCommandHandler _handler;

    [SetUp]
    public void Setup()
    {
        _handler = new ValidateCarInfoCommandHandler();
    }

    [Test]
    public async Task Test1()
    {
        CarInfoUpdateResult result = await _handler.HandleAsync(???);
        Assert.Pass();
    }
}
```

```cs
public class ValidateCarInfoCommandHandler_Tests
{
    private IValidateCarInfoCommandHandler _handler;

    [SetUp]
    public void Setup()
    {
        _handler = new ValidateCarInfoCommandHandler();
    }

    [Test]
    public async Task Test1()
    {
        CarInfoUpdateResult result = await _handler.HandleAsync(new CarInfo 
        { 
            Blah = "dno", 
            OtherThing = "no idea" 
        });
        Assert.Pass();
    }
}
```
````

<!--
Next up we update our Test to call the method that we will be implementing called Handle Async

{click}

The only issue here is what do we place as the argument? In this situation we will be receiving a record type
called CarInfo to pass in but how should we define this new CarInfo instance we are going to use

{click}

we don't know anything about CarInfo, however In this demo it's actually a pretty simple record, but there are times in which
a data type object can get relatively complicated to construct with required and optional properties. To get around
a situation like this we can actually a mock in place of the data type.
-->

---

````md magic-move
```cs
public class ValidateCarInfoCommandHandler_Tests
{
    private IValidateCarInfoCommandHandler _handler;

    [SetUp]
    public void Setup()
    {
        _handler = new ValidateCarInfoCommandHandler();
    }

    [Test]
    public async Task Test1()
    {
        CarInfoUpdateResult result = await _handler.HandleAsync(new CarInfo 
        { 
            Blah = "dno", 
            OtherThing = "no idea" 
        });
        Assert.Pass();
    }
}
```

```cs
public class ValidateCarInfoCommandHandler_Tests
{
    private IValidateCarInfoCommandHandler _handler;

    [SetUp]
    public void Setup()
    {
        _handler = new ValidateCarInfoCommandHandler();
    }

    [Test]
    public async Task Test1()
    {
        CarInfoUpdateResult result = await _handler.HandleAsync(A.Fake<CarInfo>());
        Assert.Pass();
    }
}
```

```cs
public class ValidateCarInfoCommandHandler_Tests
{
    private IValidateCarInfoCommandHandler _handler;

    [SetUp]
    public void Setup()
    {
        _handler = new ValidateCarInfoCommandHandler();
    }

    [Test]
    public async Task Test1()
    {
        CarInfoUpdateResult result = await _handler.HandleAsync(A.Fake<CarInfo>() with 
        {
            CarName = "Ford"
        });
        Assert.Pass();
    }
}
```

```cs
public class ValidateCarInfoCommandHandler_Tests
{
    private IValidateCarInfoCommandHandler _handler;

    [SetUp]
    public void Setup()
    {
        _handler = new ValidateCarInfoCommandHandler();
    }

    [Test]
    public async Task Test1()
    {
        CarInfoUpdateResult result = await _handler.HandleAsync(A.Fake<CarInfo>());
        Assert.Pass();
    }
}
```
````

<!--
{click}

This might feel a bit silly, but once again it's our job as red green refactor-a-tors to take the simpliest steps possible
to get from failing code to passing code. This includes in our test suites.

A cool thing about this approach is we are still using a record type when we define a mock this way. This means that we 
are able to use the records `with` syntax to modify individual properties

{click}

In the past, I've found that constructing complicated record type... especially those with many nested structures 
generated from a schema... can be a lot of work. I used to take a snapshot of what the data needed to look like, then 
read that snapshot in as part of my test setup, followed by JSON decoding it into my test's starting record.

But now all I have to do is define a simple little mock
-->

---

````md magic-move
```cs
public class ValidateCarInfoCommandHandler : IValidateCarInfoCommandHandler
{
}

public interface IValidateCarInfoCommandHandler
{
}
```

```cs
public class ValidateCarInfoCommandHandler : IValidateCarInfoCommandHandler
{
    public async Task<CarInfoUpdateResult> HandleAsync(CarInfo carInfo)
    {
        return null;
    }
}

public interface IValidateCarInfoCommandHandler
{
    Task HandleAsync(CarInfo carInfo);
}
```
````

<!--
Now that we have a failing to compile test, all we need to do is

{click}

Add in our definition and with it our test will pass.
-->

---

````md magic-move
```cs
public class ValidateCarInfoCommandHandler_Tests
{
    private IValidateCarInfoCommandHandler _handler;

    [SetUp]
    public void Setup()
    {
        _handler = new ValidateCarInfoCommandHandler();
    }

    [Test]
    public async Task Test1()
    {
        CarInfoUpdateResult result = await _handler.HandleAsync(A.Fake<CarInfo>());
        Assert.Pass();
    }
}
```

```cs
public class ValidateCarInfoCommandHandler_Tests
{
    private IValidateCarInfoCommandHandler _handler;

    [SetUp]
    public void Setup()
    {
        _handler = new ValidateCarInfoCommandHandler();
    }

    [Test]
    public async Task HandleAsync_Should_Exist_And_Accept_CarInfo()
    {
        CarInfoUpdateResult result = await _handler.HandleAsync(A.Fake<CarInfo>());
        Assert.Pass();
    }
}
```
````

<!--
We have now seen the first and second steps of red and green, finally comes refactor. If we have a look at the boilerplate
test we have been filling out we can see that some code cleaning up could be completed to improve upon the test suite
we are working on. In this situation that change is to rename the test to explain what we are trying to achieve

{click}

That's right, we don't have to exclusively use the refactor step on our code implementation, quite often it makes sense
to take the time to tidy up and maintain our tests. This can come from something as simple as renaming a method or variable
to extracting shared functionality between tests so that it can be shared.

You can even go as far as extracting useful functionality of your test suites into utilities of which we write their 
very own tests for! We won't be going this far for the example but the world is our oyster.

Up next why don't we start writing code towards our implementation!
-->

---

````md magic-move
```cs
public class ValidateCarInfoCommandHandler_Tests
{
    private IValidateCarInfoCommandHandler _handler;

    [SetUp]
    public void Setup()
    {
        _handler = new ValidateCarInfoCommandHandler();
    }

    [Test]
    public async Task HandleAsync_Should_Exist_And_Accept_CarInfo()
    {
        CarInfoUpdateResult result = await _handler.HandleAsync(A.Fake<CarInfo>());
        Assert.Pass();
    }
}
```

```cs
public class ValidateCarInfoCommandHandler_Tests
{
    private IValidateCarInfoCommandHandler _handler;

    [SetUp]
    public void Setup()
    {
        _handler = new ValidateCarInfoCommandHandler();
    }

    [Test]
    public async Task HandleAsync_Should_Exist_And_Accept_CarInfo()
    {
        CarInfoUpdateResult result = await _handler.HandleAsync(A.Fake<CarInfo>());
        Assert.Pass();
    }
    
    [Test]
    public async Task HandleAsync_Should_Accept_GoodInfo_And_Return_Success_Result()
    {
        var result = await _handler.HandleAsync(A.Fake<CarInfo>());
        
        Assert.True(result.Successful);
    }
}
```
````

<!--
Lets add in our new test, This one will be a cornerstone that makes sure that as we move forward we don't break
either our production code OR test suite. This is the good scenario test, as we add more tests to our codebase this
one test will quite often act as the starting point for a new test and will contain all required mocking setup code to 
achieve a passing good scenario

{click}

This test asserts that given an acceptable input, we expect the result to not
be null and to have the Successful flag set to true!

As we move forward we will find that this test does need to be updated such that it will apply the basic mocks required to achieve
a passing good scenario test. This shared setup code can either exist as a setup method we call at the top of each of our tests
or we could use the setup method. 

For now our happy path does not have any setup code so I will leave it empty.
-->

---

````md magic-move
```cs
public class ValidateCarInfoCommandHandler : IValidateCarInfoCommandHandler
{
    public async Task<CarInfoUpdateResult> HandleAsync(CarInfo carInfo)
    {
        return null;
    }
}

// public record CarInfoUpdateResult(bool Successful);
```

```cs
public class ValidateCarInfoCommandHandler : IValidateCarInfoCommandHandler
{
    public async Task<CarInfoUpdateResult> HandleAsync(CarInfo carInfo)
    {
        return new CarInfoUpdateResult(true);
    }
}

// public record CarInfoUpdateResult(bool Successful);
```
````

<!--
Now that we have our failing test due to our implementation returning null what would be the correct solution to update
our implementation to such that the test passed?

{Click}

That's right, we find the solution that takes the least effort to satisfy all the existing tests. Which just so happens
to mean we return a new result object with true pasted directly inside of it. We are taking the simplest approach
because as much as we think we know the solution, as we add more and more tests to cover each requirement
the actual end implementation will show itself.

If we were to take a bigger leap and implement more of the code ahead of our tests, that would leave us with 
un-covered functionality which can lead to bugs and often we will have incorrect assumptions and will have to
re-write that code anyway.
-->

---

````md magic-move
```cs{*|8,15}
public class ValidateCarInfoCommandHandler_Tests
{
    // ...

    [Test]
    public async Task HandleAsync_Should_Exist_And_Accept_CarInfo()
    {
        CarInfoUpdateResult result = await _handler.HandleAsync(A.Fake<CarInfo>());
        Assert.Pass();
    }

    [Test]
    public async Task HandleAsync_Should_Accept_GoodInfo_And_Return_Success_Result()
    {
        var result = await _handler.HandleAsync(A.Fake<CarInfo>());
        
        Assert.True(result.Successful);
    }
}
```
````

<!--
We have successfully gone from red to green, so that means we now have another opportunity to refactor.
Again we will be looking into the test suite itself to see what could be improved. 

I can see both some duplication and some legibility improvements that could be made here

{click}

For now the car info mock is still 100% acceptable, what isn't acceptable is that we have duplication
in the repeated implementation of it as well as no solid story behind what does A Fake CarInfo even represent.
-->

---

````md magic-move
```cs{8,15}
public class ValidateCarInfoCommandHandler_Tests
{
    // ...

    [Test]
    public async Task HandleAsync_Should_Exist_And_Accept_CarInfo()
    {
        CarInfoUpdateResult result = await _handler.HandleAsync(A.Fake<CarInfo>());
        Assert.Pass();
    }

    [Test]
    public async Task HandleAsync_Should_Accept_GoodInfo_And_Return_Success_Result()
    {
        var result = await _handler.HandleAsync(A.Fake<CarInfo>());
        
        Assert.True(result.Successful);
    }
}
```

```cs
public class ValidateCarInfoCommandHandler_Tests
{
    // ...

    [Test]
    public async Task HandleAsync_Should_Exist_And_Accept_CarInfo()
    {
        CarInfoUpdateResult result = await _handler.HandleAsync(GetGoodCarInfo());
        Assert.Pass();
    }

    [Test]
    public async Task HandleAsync_Should_Accept_GoodInfo_And_Return_Success_Result()
    {
        var result = await _handler.HandleAsync(GetGoodCarInfo());
        
        Assert.True(result.Successful);
    }

    private static CarInfo GetGoodCarInfo()
    {
        return A.Fake<CarInfo>();
    }
}
```

```cs
public class ValidateCarInfoCommandHandler_Tests
{
    // ...

    [Test]
    public async Task HandleAsync_Should_Accept_GoodInfo_And_Return_Success_Result()
    {
        var result = await _handler.HandleAsync(GetGoodCarInfo());
        
        Assert.True(result.Successful);
    }

    private static CarInfo GetGoodCarInfo()
    {
        return A.Fake<CarInfo>();
    }
}
```
````

<!--
{click again}

This is fixed by extracting that repetition into a new method GetGoodCarInfo.
By extracting a method we have achieved two things.
A) If later on more work is required to define a Car Info model, we will not need to fix multiple tests, but instead this one
implementation

And B) when we extracted the method we included a hint to the reader of what we are constructing. Of which in 
this case is a good car info model. That way later in our tests if we see somebody modifying this good car info
we know that what they are actually doing is making non good car info.

By using this pattern it can be much more likely that our test assertions are asserting a result that is due to our 
change and less likely that the test case is accidentally asserting bad data that we missed.

{click}

I have made one last refactor, I have removed the original test as now I am satisfied enough with our good case that I
don't see any value in retaining the original test.
-->

---

````md magic-move
```cs
public class ValidateCarInfoCommandHandler_Tests
{
    private IValidateCarInfoCommandHandler _handler;

    [SetUp]
    public void Setup()
    {
        _handler = new ValidateCarInfoCommandHandler();
    }
    
    // ... other tests + setup code
}
```

```cs
public class ValidateCarInfoCommandHandler_Tests
{
    private IValidateCarInfoCommandHandler _handler;

    [SetUp]
    public void Setup()
    {
        _handler = new ValidateCarInfoCommandHandler();
    }
    
    [Test]
    public async Task HandleAsync_Should_Validate_CarInfo()
    {
        var carInfo = GetGoodCarInfo();
        
        await _handler.HandleAsync(carInfo);
    }
    
    // ... other tests + setup code
}
```

```cs
public class ValidateCarInfoCommandHandler_Tests
{
    private IValidateCarInfoCommandHandler _handler;

    [SetUp]
    public void Setup()
    {
        _handler = new ValidateCarInfoCommandHandler();
    }
    
    [Test]
    public async Task HandleAsync_Should_Validate_CarInfo()
    {
        var carInfo = GetGoodCarInfo();
        
        await _handler.HandleAsync(carInfo);

        A.CallTo(() => _validator.Validate(carInfo)).MustHaveHappenedOnceExactly();
    }
    
    // ... other tests + setup code
}
```

```cs{*|3,9}
public class ValidateCarInfoCommandHandler_Tests
{
    private ICarInfoValidator _validator;
    private IValidateCarInfoCommandHandler _handler;

    [SetUp]
    public void Setup()
    {
        _validator = A.Fake<ICarInfoValidator>();
        
        _handler = new ValidateCarInfoCommandHandler();
    }
    
    [Test]
    public async Task HandleAsync_Should_Validate_CarInfo()
    {
        var carInfo = GetGoodCarInfo();
        
        await _handler.HandleAsync(carInfo);

        A.CallTo(() => _validator.Validate(carInfo)).MustHaveHappenedOnceExactly();
    }
    
    // ... other tests + setup code
}
```
````

<!--
Our next test will be a scaffolding test 

{click}

to start writing the test I implement our new test scenario by copy pasting the good scenario into our new test

{click}

adding in our assertion that some mock we are yet to define will have had it's Validate method called and our carInfo 
passed in.

{click}

from there I add in the Validator field and set it up as a fake.

{click}

And once again we have a red step as these lines won't compile as this interface doesn't exist.
-->

---

````md magic-move
```cs
public interface ICarInfoValidator
{
    bool Validate(CarInfo carInfo);
}
```
````

<!--
This can be easily resolved by defining the interface
-->

---

````md magic-move
```cs
public class ValidateCarInfoCommandHandler : IValidateCarInfoCommandHandler
{
    public ValidateCarInfoCommandHandler()
    {
    }

    public async Task<CarInfoUpdateResult> HandleAsync(CarInfo carInfo)
    {
        return new CarInfoUpdateResult(true);
    }
}
```

```cs
public class ValidateCarInfoCommandHandler : IValidateCarInfoCommandHandler
{
    private readonly ICarInfoValidator _validator;

    public ValidateCarInfoCommandHandler(ICarInfoValidator validator)
    {
        _validator = validator;
    }

    public async Task<CarInfoUpdateResult> HandleAsync(CarInfo carInfo)
    {
        return new CarInfoUpdateResult(true);
    }
}
```

```cs
public class ValidateCarInfoCommandHandler : IValidateCarInfoCommandHandler
{
    private readonly ICarInfoValidator _validator;

    public ValidateCarInfoCommandHandler(ICarInfoValidator validator)
    {
        _validator = validator;
    }

    public async Task<CarInfoUpdateResult> HandleAsync(CarInfo carInfo)
    {
        _validator.Validate(carInfo);
        return new CarInfoUpdateResult(true);
    }
}
```
````

<!--
From here we now can implement the solution to our failing test. First we need to inject in our dependency

{click}

of which I have also updated our test to pass in our mock to this constructor. Next we need to come up with an
ingenious solution... Not really

{click}

as prior, we just do what ever is the minimum amount of effort to make the test pass, which just so happens to be
that we call our method and do nothing with the result!

I will be skipping the refactor step, so we cycle back to red
-->

---

````md magic-move
```cs{*|8|*}
public class ValidateCarInfoCommandHandler_Tests
{
    // ...
    
    [Test]
    public async Task HandleAsync_Should_Return_Non_Success_When_Validation_Failed()
    {
        A.CallTo(() => _validator.Validate(A<CarInfo>.Ignored)).Returns(false);
        
        var result = await _handler.HandleAsync(GetGoodCarInfo());
        
        Assert.False(result.Successful);
    }
    
    // ...
}
```
````

<!--
now let's have a look at the way we can set up our mock of validate such that it will return false

{click}

The syntax isn't too important here, what you should  take away from this definition is that when:
A call to Validate with any carInfo parameter passed in, we need to return false
-->

---

````md magic-move
```cs
public class ValidateCarInfoCommandHandler : IValidateCarInfoCommandHandler
{
    private readonly ICarInfoValidator _validator;

    public ValidateCarInfoCommandHandler(ICarInfoValidator validator)
    {
        _validator = validator;
    }

    public async Task<CarInfoUpdateResult> HandleAsync(CarInfo carInfo)
    {
        _validator.Validate(carInfo);
        return new CarInfoUpdateResult(true);
    }
}
```

```cs
public class ValidateCarInfoCommandHandler : IValidateCarInfoCommandHandler
{
    private readonly ICarInfoValidator _validator;

    public ValidateCarInfoCommandHandler(ICarInfoValidator validator)
    {
        _validator = validator;
    }

    public async Task<CarInfoUpdateResult> HandleAsync(CarInfo carInfo)
    {
        return new CarInfoUpdateResult(_validator.Validate(carInfo));
    }
}
```
````

<!--
With this change made and our new red test ready to go, we hop into the implementation and go with the most logical solution

{click}

now when the validation result is invalid, we will get our expected false value and when it is successful it will
be true...

Only one problem.
-->

---

````md magic-move
```cs{*|10}
public class ValidateCarInfoCommandHandler_Tests
{
    // ...
    
    [Test]
    public async Task HandleAsync_Should_Accept_GoodInfo_And_Return_Success_Result()
    {
        var result = await _handler.HandleAsync(GetGoodCarInfo());
        
        Assert.True(result.Successful);
    }
    
    // ...
}
```

```cs
public class ValidateCarInfoCommandHandler_Tests
{
    // ...
    
    [Test]
    public async Task HandleAsync_Should_Accept_GoodInfo_And_Return_Success_Result()
    {
        A.CallTo(() => _validator.Validate(A<CarInfo>._)).Returns(true);
        
        var result = await _handler.HandleAsync(GetGoodCarInfo());
        
        Assert.True(result.Successful);
    }

    
    // ...
}
```
````

<!--
turns out this test is now failing due to

{click}

our Successful value actually being false!! This has happened because we had forgotten to update the happy path code
to correctly set up to validate mock to return true. I have found that the happy case breaking upon fixing the new test 
is just a part of a growing test suite and the best solution is to just amend the happy path as we go.

{click}

I won't be doing any further refactoring here, but it's quite common that mock setup code like what we just added here
might be worth making reusable, in which we could extract out the setup into a method and then
allow the caller to pass in true or false as to make this more convenient.

For now I will just be happy with how it is.
-->

---

````md magic-move
```cs{*|15-19|20-28}
    // ValidateCarInfoCommandHandler_Tests
    
    [SetUp]
    public void Setup()
    {
        _validator = A.Fake<ICarInfoValidator>();
        _logger = A.Fake<ILogger>();
        
        _handler = new ValidateCarInfoCommandHandler(_validator, _logger);
    }
    
    [Test]
    public async Task HandleAsync_Should_Log_Error_If_Validation_Failed()
    {
        var carName = "Ford";
        var carInfo = GetGoodCarInfo() with
        {
            CarName = carName
        };
        A.CallTo(() => _validator.Validate(carInfo)).Returns(false);
        
        await _handler.HandleAsync(carInfo);
        
        A.CallTo(() => _logger.LogError("Car: {CarName} invalid", carName))
            .MustHaveHappenedOnceExactly();
    }
```
````

<!--
All that remains in our little demo is to add in logging for invalid cars!

{click}

in our new test we are setting up our scenario with a specific value for our good car value such that our assertion
later specifically test that we received the expected car name

{click}

The following code would therefore currently fail because we are not calling any logging. However that is not what 
actually happens when we run the test instead we see:
-->

---

```cs
FakeItEasy.Configuration.FakeConfigurationException : 

  The current proxy generator can not intercept the method 
  Microsoft.Extensions.Logging.LoggerExtensions.LogError(
    Microsoft.Extensions.Logging.ILogger logger, System.String message, 
    System.Object[] args) for the following reason:
    
    - Extension methods can not be intercepted since they're static.
```

<!--
OH no! It appears that the interface that we relied upon isn't being used in a test-friendly way.

Under the hood, the ILogger interface only defines a single method, and what we actually called was an
extension method!

When this happens there are only two workarounds, you either implement a hand rolled mock, that exposes what 
ever conveniences you need to write your assertions OR you write your very own adapter.

We will go with the latter approach
-->

---

````md magic-move
```cs{1-4|*}
public interface ILog
{
    void LogError(string? message, params object?[] args);
}

public class LogAdapter : ILog
{
    private readonly ILogger _logger;

    public LogAdapter(ILogger logger)
    {
        _logger = logger;
    }


    public void LogError(string? message, params object?[] args)
    {
        _logger.LogError(message, args);
    }
}
```
````

<!--
The first step in writing an adapter is to determine your API. Adapters as a pattern can be applied either to tidy
up a series of interactions into a more codebase friendly API OR they can be thin layers that only exist to
extract a testable interface. Of which this adapter is an example of such.

What I have done here is gone into the implementation of the Logger extensions and stolen this definition, of which
I am now going to expose under the ILog interface.

{click}

The Log Adapter class may look very simple, this is for a reason... We won't have any tests covering this adapter, which
means we need to lower the risk of implementing a bug here. Given all we wanted to do was to update the interface we were
coding against to be testable, then this is all that we need to do

I have updated our test suite to now use the ILog interface instead of Microsoft's ILogger
Our ILog interface has the same signature as the extension so this works without issue
-->

---

````md magic-move
```cs
public class ValidateCarInfoCommandHandler : IValidateCarInfoCommandHandler
{
    private readonly ICarInfoValidator _validator;
    private readonly ILog _logger;

    public ValidateCarInfoCommandHandler(ICarInfoValidator validator, ILog logger)
    {
        _validator = validator;
        _logger = logger;
    }

    public async Task<CarInfoUpdateResult> HandleAsync(CarInfo carInfo)
    {
        return new CarInfoUpdateResult(_validator.Validate(carInfo));
    }
}
```

```cs
public class ValidateCarInfoCommandHandler : IValidateCarInfoCommandHandler
{
    private readonly ICarInfoValidator _validator;
    private readonly ILog _logger;

    public ValidateCarInfoCommandHandler(ICarInfoValidator validator, ILog logger)
    {
        _validator = validator;
        _logger = logger;
    }

    public async Task<CarInfoUpdateResult> HandleAsync(CarInfo carInfo)
    {
        var isValid = _validator.Validate(carInfo);

        if (!isValid)
        {
            _logger.LogError("Car: {CarName} invalid", carInfo.CarName);
        }
        
        return new CarInfoUpdateResult(isValid);
    }
}
```
````

<!--
now that our test suite is setup and our testable interface is ready to go, we can make our new test pass.

{click}

and with that our implementation is complete!

One of the downsides to adapting out ILogger was that microsoft chose to expose only a single method because
there are ALLOT of overrides for information, error and this results in many possible permutations that we will be stuck coding!
I personally feel like this is OK, however specifically for ILogger I would typically use a hand rolled mock instead.

This is because it's possible to add some really cool testing tech as such as tracking of scoped fields and exposing 
convenience based methods inside of your mock implementation and much more
-->

---
class: small-code
---

````md magic-move
```cs
public class FakeLogger : ILogger
{
    public readonly List<(LogLevel LogLevel, string Message, IReadOnlyList<KeyValuePair<string, object?>> State)> 
        CallList = new();
    private readonly List<IReadOnlyList<KeyValuePair<string, object?>>> _scopeStateList = new();
    
    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, // ..)
    {
        IReadOnlyList<KeyValuePair<string, object?>> stateWithScopeState = 
            [.._scopeStateList.SelectMany(l => l), ..(IReadOnlyList<KeyValuePair<string, object?>>)state!];
        
        CallList.Add((logLevel, formatter(state, exception), stateWithScopeState));
    }

    public bool IsEnabled(LogLevel logLevel) => true;

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull
    {
        var scopeState = (IReadOnlyList<KeyValuePair<string, object?>>)state;
        
        _scopeStateList.Add(scopeState);

        return new DisposableAction(() => _scopeStateList.Remove(scopeState));
    }
}
```
````

<!--
Thanks to how flexible the State generic can be there is some fairly gnarly casting that needs doing and in the example
I have shown here, and there are still flaws but this is roughly what you can arrive at as a mock for the I Logger.

With this mock we have access to write assertions on the log level, the exact message and every other field that makes
up the log call including the template parameters and scoped log state

The best part about all this is if you want to include **this** in your very own C# projects you can take this as a take home 
project, why not build out your very own logging mock using test driven development. You start
out with nothing implemented, first you write a test for the IsEnabled property, next comes a test that asserts that your 
able to retrieve the latest logs level, next the message, so on and so forth.

timing for section 15 (demo): 12m 20s
-->

---

<!--
With the demo out of the way, its no better time than ever to go over what we just saw. Firstly whenever we start out working
on our code we ALWAYS start with a failing test.
If we are writing production code and there isn't a failing test then we are failing.

From there we focused on fixing any compilation or failed test such that we could get back into a green state.
The golden rule there being that we take the path of least resistance to get back 
green, even if that step feels a little silly, if it completes another red green cycle it is the correct solution.
We will simply form another cycle to deal with the sillyness.

Next where it would make sense we would take the time to refactor, this can be as simple as renaming a test
into one that explained what the test was achieving OR it could end up being changes to code through refactoring
the code under test or even the tests themselves

We took to using mocking to both validate the internal interactions of our unit and to also substitute
out the results of calling into our mocks. By doing so we were able to exercise the app to it's fullest and
ensure that every edge case inside our unit was working as expected.

Finally when third party code got in the way of our testing we took to the adapter pattern to extract a testable interface. 
By doing so, every interaction within our codebase
is mockable and controllable and any logic that could lead to a bug can be isolated and tested.

timing for section 16: 1m 15s
-->

---

## Thank You!

<!--


-->

---
layout: cover
background: /sponsor.png
dimBackground: false
---

---
layout: center
background: "#fff"
---

<img src="/dddmelb2025.png" alt="alt" style="max-width: 400px; width: 100%;">
