function RestoredImage = WienerFilter_fft(y,h,sigma);
% RestoredImage = WienerFilter_fft(y,h,sigma);
% y: Degraded image (with blur and noise)
% h: Degrade kernel
% sigma: standard deviation of noise
R = size(y,1); %get number of rows
C = size(y,2); %get number of columns
Yf = fft2(y);
Hf = fft2(h,R,C);
Syy = abs(Yf).^2/(R*C);
See=sigma^2;
Sxx=(Syy-See);
Gf = conj(Hf)./(abs(Hf.^2)+sigma^2./Sxx);
eXf = Gf.*Yf;
RestoredImage = real(ifft2(eXf));
return
