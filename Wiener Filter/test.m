% A=magic(255);
% tic
% F1=fft2(A);
% t1=toc
% 
% tic
% F2=dft2(A);
% t2=toc
% 
% tic
% I1=ifft2(F1);
% t3=toc
% 
% tic
% I2=idft2(F2);
% t4=toc
% 
% immse(I1,A)
% immse(I2,A)
clear
clc

K=[1 5;4 7]
K1=[K zeros(2,6);zeros(6,8)];
F=fft2(K1);
F1=fft2(K,8,8);
F-F1

subplot(221)
imshow(I)
subplot(222)
imshow(I,gray(256))
subplot(223)
imshow(y,gray(256))
subplot(224)
imshow(ewx,gray(256))
