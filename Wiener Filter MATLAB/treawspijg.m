clear
clc
A=magic(512);
K=kft2(A);
F=fft2(A);
immse(K,F)

KK=ikft2(K);
FF=ifft2(K);
immse(KK,A)