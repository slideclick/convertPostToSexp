# convertPostToSexp
convertPostToSexp

1. postfix.java 处理746*89+*+5* 这是lafore的代码可以看到栈
2. GenerateASTProgram.cs可以计算其前缀S式带括号,这是我用Weiss的ADT写的
( * ( + 7 ( * ( * 4 6  )( + 8 9  ) ) )5  )
3. 如何知道\#2是对的,把S式给
java -cp peter.jar;. silk.Scheme去计算,ctrl-Z结束
(DOS选择:先选中,再上面标题栏去右键)
4.这个前缀括号拿掉后,给prefixexpressions.java去算也是2075 见sed的书程序5.4

注意,\#4是递归下降,它的栈其实和1给出的栈是一样的,只是栈是自动生成的不是\#1那样显示构造的
