This is a heavily stripped down and extremely buggy fork.

!!! PRODUCED FIRMWARE DIFFER FROM OFFICIAL NokiaCooker3.4 !!!
!!! EXPECT NOTHING TO WORK AND A BRICKED PHONE            !!!
You have been warned.


## Kind-of-working

 - Core unlocked (2B->2C)
 - Simple and small modified ROFS3 built
 - Phone still booted and was able to make sense of the new data
 - No secret modification to resource/versions/customersw.txt


## Broken

 - FAT16/UDA just does not work
 - File management capability stripped away, use explorer
 - Lots of logging disabled or happening to the invisible console
 - Bugs all over the place, many of them silent
 - In many cases files cleanup fails and there's leftovers,
   sometimes leading to incorrect data when next file is opened
 - Produced firmware files are different from "official" NokiaCooker3.4
   No idea if it's good or bad or means nothing
