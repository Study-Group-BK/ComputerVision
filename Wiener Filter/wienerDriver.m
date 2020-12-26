%% Clear
clear all
close all
clc
%% Input and display the binary image
I = imread('lenna.tif');
row = size(I,1);
column=size(I,2);
figure(1)
imshow(I)
I=rgb2gray(I);
I=double(I);
figure(2)
imshow(I,gray(256))

%% Blur the image, corrupt the image using WGN and display it
% h is the blurring filter, and sigma is the noise std
h = ones(4,4)/16;
%h=magic(4)/sum(magic(4));
sigma = 20;
Xf = dft2(I);
h=[h zeros(size(h,2),column-size(h,2));zeros(row-size(h,1),column)];
Hf = dft2(h);

y = real(idft2(Hf.*Xf))+sigma*randn(row,column); % circular convolution %randn is normally distributed
%y = filter2(h,x)+sigma*randn(N,N);	  % linear convolution

figure(3)
imshow(y,gray(256))

%% Restoration using generalized Wiener filtering
gamma = 1;
alpha = 1;
ewx = wienerFilter(y,h,sigma,gamma,alpha);
figure(4)
imshow(ewx,gray(256))

%PSNR = [psnr(y,x) psnr(eix,x) psnr(ewx,x)]
PSNR = abs([psnr(I,I) psnr(y,I) psnr(ewx,I)])
MSE = [immse(I,I) immse(y,I) immse(ewx,I)]
return
