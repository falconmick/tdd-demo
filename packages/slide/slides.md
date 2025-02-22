---
theme: the-unnamed-custom
layout: cover
background: /sponsor.png
dimBackground: false
---

<!--
First and foremost! **Thank you** to all the **sponsors**, without them such an **open and inclusive event** just isn’t possible.  
-->

---
layout: cover
---

# Unlocking Hidden Efficiency

## Seamless Solutions with TDD You Didn't Know You Needed

<!-- 
**Test Driven Development** has largely been dismissed by large swaths of **developers**, and in some cases, it's applied 
without a clear understanding of **when** and **how** to use its varying **tools** effectively.  
In this session, I will go into the **origins** of **test-driven development**;  
my **personal approach**;  
and how you can fully **leverage** its powers to become a better **developer**.
-->

---
layout: cover
background: /bingo.png
dimBackground: false
---

<!--
Also don’t forget, sponsor bingo… Maybe after my talk though!

Firstly, **who am I**?
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
**Hi!**  
I’m **Michael!**  
I am a **full stack developer** from **Perth** who spends most of his days working with **dotnet** as a glorious **virtual data plumber**.  
I like to see myself as an **overly passionate tech nerd** who can’t stop getting **excited about tech**.  
You can find me under the handle **falconmick** just about everywhere, where I talk mostly about **coding** and **console modding**.  
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
Throughout my **career**; with all the **teams** I have had the opportunity to work with; I have found the following to always be 
true: If you want to deliver **high-quality software**, **testing your code** is, without a doubt, the **key deciding factor** in how likely you are to **succeed**.  
It is not the **quality** or **quantity** of developers that matters, but instead the **discipline** the 
team takes to ensure they **validate** their code with **tests** that can be run with **minimal friction** in both **speed** and 
**resilience to change**.
-->

---
layout: center
---

# A Tale as old as time

<!--
Now before I start going over the **basics** of what **test-driven development** is, I thought it might be best to go over **why**.  
More specifically, **why** did I get sucked into the world of **testing** in the first place!  

Like most of you, I started out with a **surface-level appreciation** but at the same time a slight **disdain** for **tests**.  

A **theoretical** for us to consider:  
After spending the last **day or two** on your **PR**, the very last thing you wanted to see at **5 PM on a Friday** was that  
**60% coverage** was not acceptable to the automated code coverage overlord, **SonarQube**.
-->

---
layout: center
---

# A Tale as old as time
<h2 v-click style="position: absolute;top: 60%;">PR Failed</h2>

<!--
Nevertheless, you **work late** and add some **basic tests** to cover all the new **code**, check in the **PR**, and head 
home for a **late start** to the weekend. It didn’t help **morale** when you came in **early Monday** and the first thing you 
see is a **review** for an **obvious bug** that was **missed**.  

{click}  

It feels like you **shouldn’t have bothered** staying late, as now the **PR** is going to take a **hot minute** to fix.  
By then, all the other **developers** will be busy working on their **changes**, so this **pull request** 
isn’t seeing any more **reviews** until well into the **afternoon**.
-->

---
layout: center
---

# A New Hope?

<!--
At times like this it can feel like **tests** are there purely for the **metrics** and not to make my **codebase** any better.  
Not much good that **test** was; when it didn’t catch that **simple mistake**.  

I have had my fair share of **experiences** like this up until one day when I was on a **new team** and I had the great opportunity to 
work with **Paul**, a seasoned veteran of the **London School** of **Test Driven Development**. 
He had been around in the **London development scene** during the rise of the **London approach** as those ideas were first maturing.

-->

---

# The Three Testings Tools of Power!

<v-clicks>

- ## Red Green Refactor
- ## Mocking
- ## Adapters

</v-clicks>

<!--
There were **three main tools** he handed over to me that completely changed how I would **approach writing code** moving forward.  
Those **three tools** were:  

{click}  

**Red, Green, Refactor**, which is the practice of never writing a single line of **production code** that doesn't first have a **failing test**.  

{click}  

**Mocking**, which enabled the most valuable **design tool** in my **utility belt**.  

{click}  

And finally, **Adapters**, the practice of taking **third-party code** that doesn't line up with your **team’s patterns** and 
making a small **translation layer**.

-->

---
clicksStart: 1
---

# My First TDD Project

<v-clicks>

- ## Console App to migrate data from legacy to new
- ## Discovered outside in software design
- ## Uncovered the most powerful tool of all...

</v-clicks>

<!--
With these **three tools**, I was also handed the task of writing a fairly **mundane console app** that would use **third-party APIs** 
to explore a series of **file systems**, parse the **data within**, re-arrange the **structure** including 
**sorting** into a **new storage approach**, and then **persisting**. Basically, a **data migration project** with a few bells and whistles.  

{click}  

It was this **project** where I was first able to see the **true power** of **Test Driven Development**. Using **mocking**, my **code could 
be tested** before it was **complete**. When I came across an **impossible** to 
mock **third-party API**? **Easy—use an adapter** to expose a **more manageable interface**.  

{click}  

Finally, the **most powerful tool** and how **every line of code** was written:
-->

---
layout: center
class: spaced-h1
---

<v-clicks>

# RED
# GREEN
# REFACTOR

</v-clicks>

<!--
{click}  
&nbsp;**RED**&nbsp;
I would write a **small test** that I knew would **fail**.  

{click}  
&nbsp;**Green**&nbsp;
I implement the **fix** with as **little effort as possible**, but importantly, made the **failing test pass**. Then finally 

{click}  
&nbsp;**Refactor**&nbsp;
Now that my **new feature** has got its **implementation**, I can take a **short second** to **rearrange** and **tidy up** any **mess** left over by the **previous two steps**.  

-->

---

# My First TDD Project

<v-clicks>

- ## Flawless Victory
- ## No Debugging
- ## Beautiful Code

</v-clicks>

<!--
I took a **small sample** of our **data** and flawlessly executed this **validation migration**.  

{click}  
I then took my **backup of prod** (still not quite **believing the results**), ran the **tool**, and had a **perfect migration**.  

{click}  
No setting any **breakpoints** to **debug** a **silly weird edge case**.  

{click}  
No **last-minute restructuring** after finding that the **code just wasn't quite readable**.
-->

---
layout: center
---

# All Results; Zero Effort

<!--
It just **worked**. **Perfectly**. No **effort**. Only **results**.  

It was at that moment that I found out what all **coding** could look like;  
Welcome to the **London School** of **Test-Driven Development**.
-->

---

# Schools?

<!-- 
Before we go any further, what is all this **school nonsense**? Well, the **schools** line up with the **locations** in which  
the **approaches** were first **formalised**.
-->

---

# Schools?

- ## Detroit

<!--
The **Detroit** location came out of the **C3 project**, the **Chrysler Comprehensive Compensation Project** to be more precise,  
a **payroll re-write** being taken on by a **team** including notably **Kent Beck**, in which he founded **Extreme Programming** and went on to develop  
both the books **Extreme Programming Explained** and **Test-Driven Development by Example**, of which that last book is **coined** 
as the **origin** of **Detroit School**.
-->

---

# Schools?

- ## Detroit
- ## London

<!--
Following the **explosion** of interest in **Extreme Programming**, many **community groups** formed to learn and 
implement these ideas. One such group was the **London-based Extreme Tuesday Club**. This group played a key role in 
helping **Steve Freeman** and **Nat Pryce** refine techniques and approaches, ultimately leading to another of the most 
well-known **testing bibles**—*"Growing Object-Oriented Software, Guided by Tests."*  

This book expanded on the **Detroit School** but took a different focus. While **Detroit** emphasized testing the 
**combined interactions** of classes as a **singular unit**, this approach centered on testing **individual units** 
using **mocks**.
-->

---

# Why should I use the Detroit School?

- ## Comes naturally

<!--
Why would I pick the **Detroit school**? **Detroit** just makes sense; if up until now you had been writing a few **tests**  
here and there around all the **important stuff**; or at least to make the **metrics** look good you almost certainly have been writing  
in this **Detroit style**. You were likely missing the **red green** part, but overall you made a point to take **obvious  
chunks of functionality** out of your **codebase** and made sure that they ended up **working as you expected**.
-->

---

# Why should I use the Detroit School?

- ## Comes naturally
- ## Test as a whole, mock the pain away

<!--
Say for example you had some **logic** that would take an **existing item**, **merge** some **new state** into it and then **persisted** it back  
to the **database**. There is a very good chance that this **functionality** would be wrapped in a set of **nice tests** that  
**mocked out** the **database** with an **in-memory fake** which you then **asserted against** in the final steps of your **test methods**.
-->

---

# Why should I use the Detroit School?

- ## Comes naturally
- ## Test as a whole, mock the pain away
- ## You can refactor with confidence

<!--
If this is your **codebase** now, great! You can transition into the **Detroit school** with ease—just make sure to follow 
**Red-Green-Refactor**, and you're basically there!  

Once you commit to **testing** every feature as you add it, you'll find that **refactoring** comes with more **confidence**. 
Why? Because if a feature is **important**, you'll have a **test** around it.  

And if you break that feature later while applying a fix, those **tests** you wrote **six months ago** will be there to 
**catch you**—before you release broken functionality to your **users**.
-->

---

# Why should I use the Detroit School?

- ## Comes naturally
- ## Test as a whole, mock the pain away
- ## You can refactor with confidence
- ## Works wonders in some situations

<!--
Another time that the **Detroit approach** can really shine is when writing **small self-contained utilities** which have **no side effects** and  
simply take **incoming arguments** and **transform them into an output** based off a series of **known rules**. Because of this,  
**code katas** such as **supermarket pricing examples** or others can be a **good way to practice Test Driven Development** in  
the **Detroit style**.

-->

---

# Why should I use the Detroit School?

- ## Comes naturally
- ## Test as a whole, mock the pain away
- ## You can refactor with confidence
- ## Works wonders in some situations
- ## Pushes you to isolate complexity

<!--
From there, you will find it easier to spot **good sections** of your **codebase** to treat as a **unit** for your  
**testing**. This will help guide your **coding** in such a way to push any required **side effects** to the **edges** of your **codebase**  
such that they are much easier to **mock**. This is showing us that **testing** not only can add **reliability** but also encourage us to  
write our code in such ways to **isolate complexity**.
-->

---

# Why wouldn't I use the Detroit School?

- ## Test-Splosions

<!--
One reason why you might **not** want to use this style of **testing** is the dreaded **1-line change** that breaks **multiple test suites**.  
When our **unit under test** combines **multiple shared snippets of code**, there is a large chance that eventually you will be  
writing a **new feature** or fixing a **bug**, and out of nowhere, **all your tests start failing**. When this happens, especially if  
you accidentally forgot to keep your **red-green-refactor** iterations **small**; or worse yet, you were **not doing so**; the **instant  
stress** of having an entire set of **test suites start failing** can make it hard to find the **code change** that was at **fault**.
-->

---

# Why wouldn't I use the Detroit School?

- ## Test-Splosions

<!--
There are **workarounds** for this issue. Most importantly, you can focus on making sure your **entire test suite** runs continuously,  
so that any **regressions** are caught **as soon as** changes are made. If something breaks, you can just **control zed on that thang**  
until you find the **responsible line of code**.  

But this kind of challenge is just **part of testing**— with detroit. If your unit of test has many
overlapping suites, you will find that you can topple a **house of cards** with a **smallest** of a mistake.

Alternatively, this kind of **pain** can be nearly eliminated by the **London School** approach. With London School,  
you should **never** be re-testing shared functionality between classes. The only thing that can break a test in a given suite  
is code that exists **within that very class**, since each test treats the **class itself** as the unit under test.
-->
---


# Why wouldn't I use the Detroit School?

- ## Test-Splosions
- ## Short term speed loss

<!--
Some would argue that another reason to avoid the **Detroit school**—or even **Test-Driven Development** altogether—is 
the **short-term speed loss**.  
But this concern really only applies to **small-scale changes** in existing **codebases** that don't **cooperate with tests**.  

In the **long run**, though, taking the time to **write tests now** can save a lot of **headache later**. That said, 
there are **occasional cases** where it just **isn't worth it**.  

It's important to note that if you're trying to **migrate to TDD**, the **Detroit school** is by far the 
**quicker approach** compared to **London**.  

For this reason, when jumping into an **existing codebase**, **Detroit** might be the **only logical approach**.  

-->

---
clicksStart: 1
---

# Why should I use the London School?

<v-clicks>

- ## BIAS ALERT!!!
- ## Once you know... you know

</v-clicks>

<!--
**Bias warning**—I love the **London approach**.  

{click}
The **London school** is, by far, much harder to sell without first experiencing it. 
But I can only say—it's worth taking the time to try it out and see **where the code takes you**.  

And that’s actually one of its biggest draws, especially when compared to **Detroit**. When you write in **London style**, 
there’s less need to think ahead about what classes will be required to form your tests around.
-->

---

# Why should I use the London School?

- ## BIAS ALERT!!!
- ## Once you know... you know
- ## Tests come fast and without dependencies

<!--
Instead, you naturally start at the **origin** of your feature—such as the **API endpoint**—and use your **tests** to 
define the structure of your class. If the first step in handling an **incoming request** is to **validate the input**, then you write a test to assert this. 

It doesn’t matter that the **validator interface** doesn’t exist yet—you can go ahead and define it. Once you have an 
interface that accepts the input and returns a suitable output, you **skip the implementation** and instead create a 
**mock** for your new interface. You then use the **assertion tools** provided by the mock to ensure that the validator is called.

Later, in another test, once you implement the call, you can **stub out the functionality**, making it easy to set up 
tests that validate each **unique** and potentially **hard-to-reproduce** branch in your class.
--> 

---

# Why should I use the London School?

- ## BIAS ALERT!!!
- ## Once you know... you know
- ## Tests come fast and without dependencies
- ## Outside In code flow

<!--
This process **repeats over and over**, without any of the other **downstream classes** needing to be implemented. We instead  
focus purely on the **branches** and **edge cases** tracked by this **class**.  

This, to most **sane developers**, will sound **outlandish** spending multiple **coding iterations** writing **tests** that prove  
obvious thing **X** was passed to other obvious thing **Y**. **What exactly am I gaining??**  

Well, what you are gaining is **software** that is designed with an **outside-in style**. I have found that if I work my way from  
the **outside** of my **code** all the way **in**, I am able to discover **shared responsibilities** much sooner and can invest in  
designing much more **understandable APIs** as I develop, rather than coming back and **re-working** them later.
-->

---

# Why should I use the London School?

- ## BIAS ALERT!!!
- ## Once you know... you know
- ## Tests come fast and without dependencies
- ## Outside In code flow
- ## Everything is testable

<!--
Because we **mock every single call** and never depend on external code within our unit, our entire **codebase remains 
open to substitution** at any time.  

A great example of this is when, later in the project, you encounter a **race condition bug** caused by tiny differences 
in calls to **DateTime.Now**. If we had been testing **without mocks**, all our time-sensitive code—now causing us 
headaches—would be **un-mockable** and nearly impossible to reproduce in a test.  

With the **London style**, everything is **injected**, meaning **anything can be mocked**.
-->

---
layout: center
---

# London's Calling

<!--
I would say the **final** and possibly **most impactful tool** that the **London School** gives you is that it makes **splitting up**  
your **features** into **smaller tickets** a much more **manageable process**. I have found that most **teams** that I work with who  
**don’t use** the **London approach** will typically find themselves having a **single developer** delivering an **entire feature**  
from **start to end**, even if the **ticket** is split up into **multiple steps**.
-->

---
layout: two-cols
dragPos:
  harry: 115,398,161,161
  kiara: 661,395,161,161
  "'foo'": 394,295,40,40
  "'circleTwo'": 825,290,40,40
  "'bar'": 697,441,89,74
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
If a team splits the ticket, assigning **Harry** to map the user input into a domain model and **Kiara** to handle SQL 
persistence, they might run into an unfortunate issue—both developers end up implementing their own version of the **same file**.

{click} For example, **Harry**  defines `CarInfo` as a **record**.

{click} Meanwhile, **Kiara** also implements `CarInfo`, but because they're using **Entity Framework**, 

a library that **relies on class mutation** to track field updates for generating SQL queries, their version is a 
**mutable class** instead.

{click} Now, one of them has to **rework their implementation**, and neither is happy about it.

{click} This is why, quite often, when a team writes up their tickets, they end up turning **the feature ticket** into 
**the entire ticket**, rather than breaking it down into the individual steps needed to complete the feature.  

If, instead of **six small tickets**, we had **one big ticket**, a single developer could pick it up and work through it 
**from start to finish** without running into these conflicts. But now our work
is in **bigger chunks** which can lead to **half complete** sprints with **no tickets** left
-->

---
layout: center
---

# London's Calling 

<!--
This all could have been avoided if the priority was to deliver the **domain models** and **interfaces** at an earlier stage.  
So sometimes this will happen, a **feature** will have an initial **ticket** that defines the **API endpoint** and also sets up  
the basic **interfaces** such as the **validator**, **mappers**, and **database layer**. However, because  
they write tests in the **Detroit style**, they will not be able to write any **tests** for this code as  
we are yet to implement any of these **interfaces**. Now we are going to check in a lot of code with **0 code coverage**  
as we cannot write any **tests** for this code yet as it is not implemented. This can often lead to code that doesn't  
play nice with **testing** later on, as the hardest **code to write tests for** is that **code which already exists**.
-->

---
layout: center
---

# London's Calling 

<!--
Instead of **not testing** this important **upper layer**, what if we just, for now, **mocked away** all the **mappers**, **validators**, and  
**persistence calls**? Well, now if later down the line we find a **bug** in this layer of the **codebase**, we know for a fact  
that we will be able to easily **re-create the bug** as a **test**, then **fix it** and **validate** the fix is good through that  
**test passing**. The **London approach** forces us to at all times **write code** that has a **failing test**, and it also makes each  
line we write more **testable**.
-->

---
layout: center
dragPos:
  stopwatch: 365,318,223,223
---

# London's Calling 

<img v-drag="'stopwatch'" src="/stopwatch.png" />

<!--
If your **team** is finding that their **tickets** are taking **more 
than a day** to complete, this is a good sign that you most likely need to **split up** your tickets into **smaller, 
bite-sized tickets** that take at most **half a day** to complete. It is at that point that you also might find that 
**swapping to the London approach** will make all of that much more **manageable**.
-->

---

# Why not to use the London School?

- ## Maintenance of Scaffolding

<!--
**Maintenance** is by far the largest reason why **Detroit** might be a **better pick** for you and your team over **London**.  
When you write **40 tests** for a **single class**, and a bunch of them are **basic scaffolding tests** that don't really **test much**,  
you will find that a **simple change** that **refactors** a clump of code from one **class** into another can be **excruciating** to move.  

To do so **correctly**, you would have to basically fully **re-create** the entire **red-green-refactor** for the entirety of the  
**code being moved**, plus **set up new tests** in the **old class** to validate that the **refactored chunk of code's interface** is being  
**correctly called**.

-->

---

# Why not to use the London School?

- ## Maintenance of Scaffolding
- ## Refactoring takes effort

<!--
When you're simply trying to just **clean up**, this can be **burdensome** and might lead to **less time spent refactoring**.  
There is a **silver lining** here in that it can help if you're suffering from **premature re-fac-tile dysfunction**,  
but realistically, making it this **hard to get work done** can be a **problem**.
-->

---

# Why not to use the London School?

- ## Maintenance of Scaffolding
- ## Refactoring takes effort

<!--
With that said, I've noticed that with a **small bend** in the rules, you can **cut, paste, and refactor** the unit tests 
themselves—essentially **shuffling the original tests** into place without ever going through the proper **red-green-refactor** process.  

Another approach would be to, once a unit test is complete, **go back** through the suite and **remove the scaffolding tests**, 
leaving only those that **validate the extremities** of the unit. This is the **by-the-book** way to manage this complexity.  

But honestly? **I’ve always struggled** with deleting my tests—I just want to **keep all my babies.**  

-->

---
layout: center
---

# Which one should I be following?

<!--
It can sometimes be **hard to know** what is the **correct approach** to take when writing **tests** for your **codebase**.  
Do I take the **Detroit approach**, which more closely matches up with how **developers instinctively test**,  

**OR**  

do I take a much more **extreme route** and allow my **tests to define my API**, choosing to **chip away** at the **code** one  
**concern at a time** through the **isolation** that **mocking** allows?
-->

---
layout: center
dragPos:
  itDepends: 356,345,265,72,7
---

# Which one should I be following?
<h1 style="text-wrap: nowrap" v-drag="'itDepends'">It Depends</h1>

<!--
The answer to this is everybody's favourite; **it depends**; however, this time we get to complete that sentence by saying  
**it depends on your team**.  

One of the **biggest mistakes** any new developer, no matter the seniority, can make when joining a new team is to try and  
**uproot an established team coding approach** and replace it with their own.  

Does that mean if you join a team, and they have **no real testing strategy**, just **a few tests here and there**, that  
you cannot come in and **improve things**?
-->

---
clicksStart: 1
---

# Introducing TDD to your team

<v-clicks >

- ## Keep it simple, use Detroit School
- ## Talk to your Team

</v-clicks>

<!--
No, it does not. What it means is you have a team who is **open to the idea of testing**, they just need **a little help**.  
What that also means is more **involved practices** like the **London school** are more than likely **a no-go**, as chances are there are  
**landmines scattered throughout the codebase** that will likely **refuse to be isolated with mocking**, so you will want to  
**minimise your mocking** and focus less on writing **unit tests** and more on **integration-ish tests**.  

{click} It is important to **talk with your colleagues**, get their **feedback** on how **code is being written** and also to provide  
**some ideas** on how things **could be improved** to see how that **works for the team**. Most developers **know deep down** they  
**should be writing tests** but just **struggle to justify their time** doing so. If you come in and **help make testing the norm**,  
you will likely find they **come with you, willing and happy**.

-->

---
clicksStart: 4
---

# Introducing TDD to your team

<v-clicks >

- ## Keep it simple, use Detroit School
- ## Talk to your Team
- ## Start out London, failsafe to Detroit

</v-clicks>

<!--
What this all mostly boils down to is there is a high chance you should just use **Detroit** even if deep down you really  
wish you could be writing **London**, which has been my reality for most of my recent engagements. If a **new project** is coming  
up and you're **confident** with the **London** approach, why not start out with **heavy mocking** and see how it works for your team?  
You can always **pivot to Detroit** if it's not working out. By that point, hopefully, even if you do have to **remove the London  
style**, your **codebase** will already have a bunch of **clarity** from the **outside-in work** done so far.  
-->

---
layout: center
---

# Going deeper

<!--
Now that we know about the **different approaches** to **Test Driven Development**, now could be no better time than  
ever to go back to the **techniques** that we can apply to our **coding** and give some **better explanations** and **examples**  
of what it looks like to **properly implement** them.  

Starting with a **Red Green Refactor** example using **JavaScript**.  
-->

---
layout: center
class: spaced-h1
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

First, we write a **test** that will **fail**, it should be **small** and **easy to write**.  

{click}  

It doesn't even have to **compile**, **red** can refer both to the **test status bar** or the **syntax error** caused by  
the **non-existent sum function** your test is referring to.
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
{click to undo highlight}  
Now we need to make the test work with the **minimal amount of changes** as possible; **all sins permitted**.  
Was your test that **two plus two equals four**? Great, **stub out the method** with the two arguments then **return four**.  

{click}  

It does not matter that our **implementation is obviously wrong**, that is **100% ok**!  
If you can look at an implementation and see that it is **flawed**, that is a sign that you **do not have enough tests yet**,  
and you need to continue the **red-green-refactor cycle** until you come to a more **concrete output**.  
This approach is known as **stutter testing** and can often be used in conjunction with **triangulation approaches**.  
-->

---
layout: default
dragPos:
  "'circleTwo'": 362,281,30,30
  "'circleOne'": 281,216,40,40
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
````

<v-drag pos="'circleOne'" v-mark="{ at: 1, color: '#934', type: 'circle' }"></v-drag>
<v-drag pos="'circleTwo'" v-mark="{ at: 1, color: '#934', type: 'circle' }"></v-drag>

<!--
Refactor is a key part of the **design** aspect of test driven design.  
If you have been following TDD correctly, your solution will be as **minimalistic** as possible.  
Does the world's most **understandable and maintainable code** come into existence for free? Normally not,  
so the **refactor stage** is to make code that you feel **comfortable** checking in.  

{click}
In this specific instance, our refactoring is required to **remove duplication**  
between our test, which defines **4 as the expected result**, and our implementation, which just parrots it back to us.
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
{click}  
This is a really **minimalistic** example which  
is why this might feel a bit **silly**, but the point of this example is that even if a **solution feels wrong**, if it  
**satisfies the test** it is **correct**. It is the point of the **refactor step** to remove **duplication** and **tidy up**.  
-->

---

# REFACTOR

````md magic-move
```js
it('Should sum 2 plus 2 to equal 4', () => {
    const result = sum(2, 2)
    
    expect(result).toBe(4)
});

const sum = (augend, addend) => augend + addend;
```
````

<!--
In more realistic scenarios quite often the act of adding on additional tests will flush out the silly solutions
we come up with to satisfy the first few tests we write.

Your **test code** is just as important as your **production code**. If there's **duplication** in your tests that could 
be solved with **refactoring**, the best time to fix it is when your **codebase is green**. Apply these fixes with the 
same **rigor** as you would in your **production code**.
-->

---

# Mocking

- ## Concrete Implementation of Interfaces

<!--
Another tool that is invaluable is **mocking**, in particular **extensive mocking**.

**Mocking** sounds like a simple subject; but depending on how you **approach** it you can get vastly different **results**.

One such approach is creating a **new concrete implementation** of an **interface** that is **injected** into your **codebase** that 
was designed purely for **testing**, say for example a **mock implementation** of your **database**. This implementation won't always 
be fully **extensive** but will allow us to **simulate** calling out to the **real database** without any of the **drawbacks** 
of using a **real database** during **testing**. Through creating the **mock by hand** we also have the ability to **embed test utilities** 
such as **data initialization** or whatever other **test utility** we can put our minds to.

-->

---

# Mocking

- ## Concrete Implementation of Interfaces

<!--
This is a **common approach** in the **Detroit School** of TDD. By creating a **concrete implementation**, 
we allow a series of interactions to build up naturally.  

For example, we might have a **test** that first **retrieves a value** from the **database** and then **modifies it**. 
Without mocking, the next test run might **fail** because the data has **already changed**.  

Alternatively, if we had used a **substitution framework** instead of a **handcrafted mock**, we would have needed to write 
**a lot of extra setup code** to handle these interactions.
-->

---

# Mocking

- ## Concrete Implementation of Interfaces
- ## Substitution Frameworks

<!--
Speaking of **substitution frameworks**; in **C#** we have **Moq**, **FakeItEasy**, or **NSubstitute** just to name a few.  
These tools allow for **expressions** to be written which get **called in place** of the **interface** we supply them,  
allowing us to **define inline** to our **test** what that **call will return** OR even allow us to **assert** that the **call was made at all**.
-->

---
dragPos:
  "'dragons'": 433,306,425,128,-38
  "'dragonsInvis'": 418,333,407,98,49
---

# Mocking

- ## Concrete Implementation of Interfaces
- ## Substitution Frameworks

<v-drag pos="'dragonsInvis'"><h1 style="color: #ffffff00">Here be Dragons</h1></v-drag>
<v-drag pos="'dragons'"><h1>Here be Dragons</h1></v-drag>

<!--
The only thing to keep in mind here is even though these frameworks do have some support for classes in languages like C#, they are limited
and a lot of the time a mock around a class will fail. It is for this reason that when using lots of mocking you tend
to also need to be stricter with the separation of logic to data and also the usage of adapters on third party code.
-->

---

# Adapters

- ## Remove implementation details from third-party code

<!--
The **Adapter Pattern** isn’t a strict rule, but rather a way to introduce an **adapter layer** that abstracts away 
**third-party code** instead of relying on it directly. This can help remove **implementation details** from our dependent codebase.  

For example, an **adapter** might provide a **getter** that first sets up a **factory** for the third-party component 
and then executes it—all while keeping the interaction **simpler** and more **aligned** with how we write code in our codebase.
-->

---

# Adapters

- ## Remove implementation details from third-party code
- ## Must be free from complexity

<!--
It is only important that this layer remain as simplistic as possible as it can often not be viable to test it 
without integration testing, so if your adapter grows too much you will end up having dangerously uncovered section of code.

-->

---

# Adapters

- ## Remove implementation details from third-party code
- ## Must be free from complexity
- ## Essential in London School

<!--
When following the London approach of test driven development the use of adapters
will be a lot more extensive than you might expect,
-->

---

# Adapters

- ## Remove implementation details from third-party code
- ## Must be free from complexity
- ## Essential in London School
- ## Enables fine-grain control of tests through mocking

<!--
I even adapted out DateTime, which gives our tests the ability to act as
Pure functions which leads to less brittle testing and also makes testing edge cases a cakewalk as we have
full control over how much the time changes between each call to Now. When I go over a detailed example of how I think
TDD should be implemented in my C# example I will dig into adapters further.
-->

---

# Example Time

- ## C# with the London School Approach

<!--
For this example I will use C# and the London School approach as this is my bread and butter, With this I will be able 
to give a concrete example of how Test Driven Development can be implemented. 
I will be taking all the three key concepts from today and combining
them together to validate a record passed in and then return that result. If the validation failed I will also log that
-->

---

# Example Time

- ## C# with the London School Approach
- ## Nunit, FakeItEasy

<!--
To make this demo possible I am using the following tools:

- NUnit, my test runner and assertion library
- and FakeItEasy, a mocking library that allows for inline definitions of mocks and also exposes several
useful tools to validate how our mocks have been interacted with

-->

---

# Example Time

- ## C# with the London School Approach
- ## Nunit, FakeItEasy
- ## Live demo? More like live mistake!

<!--
Originally this was going to be live, but then I opened up my mac laptop and remembered all my bindings are windows
based and I am 100% completely lost... So in the interest of not flapping around like a grounded fish for the next 10
min, I will instead jump to my backup slides for this demo.

- Note to self: If I swap to Windows machine in the future, blame my macOS keybindings
- note to self 2: Don't read above note out aloud
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

```cs {*|3,8}
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

Note how all I need do to get into the green is simply define the interface and the implementation
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
````

<!--
Next up we update our Test to call the method that we will be implementing called Handle Async

{click}

The only issue here is what do we place as the argument? In this situation we will be receiving a record type
called CarInfo to pass in but how should we define this new CarInfo instance we are going to use
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
````

<!--
{click}

This might feel a bit silly, but once again it's our job as red green refactor-a-tors to take the simpliest steps possible
to get from failing code to passing code. This includes in our test suites.

A cool thing about this approach is we are still using a record type when we define a mock this way. This means that we 
are able to use the records `with` syntax to modify individual properties
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
{click} In the past, I've found that constructing complicated record type... especially those with many nested structures 
generated from a schema... can be a lot of work. I used to take a snapshot of what the data needed to look like, then 
read that snapshot in as part of my test setup, followed by JSON decoding it into my test's starting record.

But now all I have to do is define a simple little mock, then use the `with` keyword to customise
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
````

<!--
We have now seen the first and second steps of red and green, finally comes refactor. If we have a look at the boilerplate
test we have been filling out we can see that some code cleaning up could be completed to improve upon the test suite
we are working on. In this situation that change is to rename the test to explain what we are trying to achieve
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
{click} We don't have to exclusively use the refactor step on our code implementation, quite often it makes sense
to take the time to tidy up and maintain our tests. This can come from something as simple as renaming a method or variable
to extracting shared functionality between tests so that it can be shared.

You can even go as far as extracting useful functionality of your test suites into utilities of which we write their 
very own tests for! We won't be going this far for the example but the world is our oyster. Up next why don't we start 
writing code towards our implementation!
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
Lets add in our new test, This one will be a cornerstone that makes sure that as we move forward we don't break either our production code OR test suite. 

{click}
This is the good scenario test, as we add more tests to our codebase this
one test will quite often act as the starting point for a new test and will contain all required mocking setup code to 
achieve a passing good scenario

This test asserts that given an acceptable input, we expect the result to not
be null and to have the Successful flag set to true!

As we move forward we will find that this test does need to be updated such that it will apply the basic mocks required to achieve
a passing good scenario test. This shared setup code can either exist as a setup method we call at the top of each of our tests
or we could use the setup method provided by our test runner.
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
````

<!--
Now that we have our failing test due to our implementation returning null what would be the correct implementation such that to get our test to pass?
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
{click} That's right, we find the solution that takes the least effort to satisfy all the existing tests. Which just so happens
to mean we return a new result object with true pasted directly inside of it. We are taking the simplest approach
because as much as we think we know the solution, as we add more and more tests to cover each requirement
the actual end implementation will show itself.

If we were to take a bigger leap and implement more of the code ahead of our tests, that would leave us with 
un-covered functionality which can lead to bugs and often we will have incorrect assumptions and will have to
re-write that code anyway.
-->

---
dragPos:
  "'circleOne'": 521,310,168,40
  "'circleTwo'": 674,178,168,40
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

<v-drag pos="'circleOne'" v-mark="{ at: 1, color: '#934', type: 'circle' }"></v-drag>
<v-drag pos="'circleTwo'" v-mark="{ at: 1, color: '#934', type: 'circle' }"></v-drag>

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

This is fixed by extracting the repeated code into a new method: **GetGoodCarInfo**.  

By doing this, we achieve two things:  

1. If we later need to refine the **Car Info model**, we won’t have to modify multiple tests—just this **one implementation**.  

2. When extracting the method, we also add a **clear hint** to the reader about what we are constructing: a **good car info model**. 
This makes it obvious that if someone later modifies **GoodCarInfo**, they are acting **with purpose**.  

By following this pattern, our test assertions are more likely to validate the **intended changes** rather than 
accidentally assert against **bad data** that we overlooked.  

{click}  

For one final refactor, I’ve **removed the original test**. Now that I’m confident in our **good case**, 
keeping the original test no longer adds value.
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

now I add in on an assertion that a new mock we are yet to define will have had it's Validate method called 

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

of which I have also updated our test to pass in our mock to this constructor aswell. Then we need to come up with an
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
From here we need another test, in this one we will be mocking out what Validate returns, such that it returns false

{click}

The syntax isn't too important here, what you should  take away from this is that when:
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
turns our happy path test is now failing due to

{click}

our Successful value actually is actually false!! This has happened because we had forgotten to update the happy path code
to correctly set up to validate mock to return true. I have found that the happy case breaking upon completion of a red green cycle
is just a part of a growing test suite and the best solution is to just amend the happy path as we go.

{click}

I won't be doing any further refactoring here, but our mock setup code that we just added
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
        var carInfo = GetGoodCarInfo() with
        {
            CarName = "Ford"
        };
        A.CallTo(() => _validator.Validate(carInfo)).Returns(false);
        
        await _handler.HandleAsync(carInfo);
        
        A.CallTo(() => _logger.LogError("Car: {CarName} invalid", "Ford"))
            .MustHaveHappenedOnceExactly();
    }
```
````

<!--
All that remains in our little demo is to add in logging for invalid cars!

{click}

in our new test we are setting up our scenario with a specific value for our car info to make our latter assertions more deliberate feeling

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

Under the hood, the ILogger interface only defines a single method, what we actually called was an
extension method!

When this happens there are only two workarounds, you either implement a hand rolled mock, that exposes what 
ever conveniences you need to write your assertions OR you write your very own adapter.

We will go with the latter approach
-->

---

````md magic-move
```cs{1-4}
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
-->

---

````md magic-move
```cs
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
The Log Adapter class may look very simple, but this is for a reason... We won't have any tests covering this adapter, which
means we need to lower the risk of implementing a bug here. 

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
there are ALLOT of overrides for information, error and more.
I personally feel like this is OK, however specifically for ILogger I would typically use a hand rolled mock instead.

This is because it's possible to add some really cool testing tech as such as tracking of scoped fields and exposing 
convenience based methods inside of your mock implementation
-->

---
class: small-code
dragPos:
  qr: 784,20,176,176
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

<img v-drag="'qr'" src="/tddqr.png" />

<!--
No I don't expect you to memorise this, QR code links to this incomplete-ish implementation

Thanks to how flexible the State generic can be there is some fairly gnarly casting that needs doing and in the example
I have shown here, and there are still flaws but this is roughly what you can arrive at as a mock for the I Logger.

With this mock we have access to write assertions on the log level, the exact message and every other field that makes
up the log call including the template parameters and scoped log state

The best part about all this is if you want to include **this mock** in your very own C# projects you can take this as a take home 
project, why not build out your very own logging mock using test driven development. You start
out with nothing implemented, first you write a test for the IsEnabled property, next comes a test that asserts that your 
able to retrieve the latest logs level, next the message, so on and so forth.
-->

---
clicksStart: 1
---

# Demo Recap

<v-clicks>

- ## Always write a failing test before you write prod code
- ## The quickest/dirtiest/silliest solution is the best solution

</v-clicks>

<!--
With the demo out of the way, its no better time than ever to go over what we just saw. Firstly whenever we start out working
on our code we ALWAYS start with a failing test.
If we are writing production code and there isn't a failing test then we are failing.

{click}
From there we focused on fixing any compilation or failed test such that we could get back into a green state.
The golden rule there being that we take the path of least resistance to get back 
green, even if that step feels a little silly, then it is the correct solution.
We will simply form another cycle to deal with the silliness.
-->

---
clicksStart: 3
---

# Demo Recap

<v-clicks>

- ## Always write a failing test before you write prod code
- ## The quickest/dirtiest/silliest solution is the best solution
- ## Refactor out duplication add clarity

</v-clicks>

<!--
Next where it would make sense we would take the time to refactor, this can be as simple as renaming a test
OR it could end up being changes to code through refactoring
our production code or even our unit tests themselves
-->

---
clicksStart: 4
---

# Demo Recap

<v-clicks>

- ## Always write a failing test before you write prod code
- ## The quickest/dirtiest/silliest solution is the best solution
- ## Refactor out duplication add clarity
- ## Mocking can set-up and validate code

</v-clicks>

<!--
We took to using mocking to both validate the internal interactions of our unit and to also substitute
out the results of calling into our unimplemented interfaces. By doing so we were able to exercise the app to it's fullest and
ensure that every edge case inside our unit was working as expected.
-->

---
clicksStart: 5
---

# Demo Recap

<v-clicks>

- ## Always write a failing test before you write prod code
- ## The quickest/dirtiest/silliest solution is the best solution
- ## Refactor out duplication add clarity
- ## Mocking can set-up and validate code
- ## Adapt away any issue that stops you from testing

</v-clicks>

<!--
Finally when third party code got in the way of our testing we took to the adapter pattern to extract a testable interface. 
By doing so, every interaction within our codebase
is mockable and controllable and any logic that could lead to a bug can be isolated and tested.
-->

---
layout: center
---

# Final Thoughts

<!--
Coming into this session I am sure we have had a bunch of differently experienced developers. From the new to testing,
those who begrudgingly add test around their code and maybe even a few people who have a whole
lot of testing experience.

For those who are new, I hope that this can serve as some inspiration to look deeper into the concepts of red, green
refactor.
-->

---
layout: center
---

# Final Thoughts

<!--
Those of us out there who know their way around a tdd cycle but never saw the point, I hope that this gets you excited
to give a more structured approach a go, check out Kent Becks book on testing if you can get the chance.

Finally to those out there who are experienced test driven developers, I am sure many of you have dismissed mocking
approach of London School. I really hope that you can use the concepts of adapters and fluent mocking frameworks
to your advantage and given the London approach another go.
-->

---
layout: center
---

## Thank You! 

Questions (time permitting)

<!--
Thank You

**REMINDER**

Move to sponsor slide after questions
-->

---
layout: cover
background: /sponsor.png
dimBackground: false
---

<!--
Thank-you again to all the sponsors
-->

---
layout: center
background: "#fff"
---

<img src="/dddmelb2025.png" alt="alt" style="max-width: 400px; width: 100%;">
